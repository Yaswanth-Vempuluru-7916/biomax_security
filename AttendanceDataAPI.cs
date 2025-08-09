using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace AttendanceDataAPI
{
    public class AttendanceRecord
    {
        public string UserId { get; set; }
        public DateTime LogTime { get; set; }
        public string VerifyMode { get; set; }
        public string InOutMode { get; set; }
        public int WorkCode { get; set; }
    }

    public class ExtractionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int TotalRecords { get; set; }
        public List<AttendanceRecord> Records { get; set; }
        public DateTime ExtractionTime { get; set; }
    }

    public class AttendanceController : ApiController
    {
        private const string DEVICE_IP = "10.67.20.120";
        private const int DEVICE_PORT = 5005;
        private const int MACHINE_NUMBER = 1;
        private const int PASSWORD = 0;
        private const int TIMEOUT = 5000;
        private const int LICENSE = 1261;

        [HttpGet]
        [Route("api/attendance")]
        public HttpResponseMessage GetAttendanceData(DateTime? startDate = null, DateTime? endDate = null)
        {
            var result = ExtractAttendanceData(startDate, endDate);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("api/attendance/all")]
        public HttpResponseMessage GetAllAttendanceData()
        {
            var result = ExtractAttendanceData();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("api/device/status")]
        public HttpResponseMessage GetDeviceStatus()
        {
            try
            {
                int handle = FKAttendDLL.FK_ConnectNet(
                    MACHINE_NUMBER,
                    DEVICE_IP,
                    DEVICE_PORT,
                    TIMEOUT,
                    0, // PROTOCOL_TCPIP
                    PASSWORD,
                    LICENSE
                );

                if (handle > 0)
                {
                    FKAttendDLL.FK_DisConnect(handle);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Status = "Connected", Message = "Device is accessible" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Status = "Disconnected", Message = $"Connection failed with error code: {handle}" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "Error", Message = ex.Message });
            }
        }

        private ExtractionResult ExtractAttendanceData(DateTime? startDate = null, DateTime? endDate = null)
        {
            var result = new ExtractionResult
            {
                Success = false,
                Records = new List<AttendanceRecord>(),
                ExtractionTime = DateTime.Now
            };

            try
            {
                // Step 1: Connect to device
                Console.WriteLine("Step 1: Connecting to device...");
                int handle = FKAttendDLL.FK_ConnectNet(
                    MACHINE_NUMBER,
                    DEVICE_IP,
                    DEVICE_PORT,
                    TIMEOUT,
                    0, // PROTOCOL_TCPIP
                    PASSWORD,
                    LICENSE
                );

                if (handle <= 0)
                {
                    result.Message = $"Failed to connect. Error code: {handle}";
                    return result;
                }

                Console.WriteLine($"✓ Connected successfully! Handle: {handle}");

                // Step 2: Disable device during operation (same as sample app)
                Console.WriteLine("Step 2: Disabling device for data extraction...");
                int disableResult = FKAttendDLL.FK_EnableDevice(handle, 0);
                if (disableResult != (int)enumErrorCode.RUN_SUCCESS)
                {
                    result.Message = $"Failed to disable device. Error code: {disableResult}";
                    FKAttendDLL.FK_DisConnect(handle);
                    return result;
                }

                // Step 3: Load attendance data
                Console.WriteLine("Step 3: Loading attendance data...");
                int loadResult;
                
                if (startDate.HasValue && endDate.HasValue)
                {
                    // Load data by date range (same as "Read Log by Date" button)
                    loadResult = FKAttendDLL.FK_LoadGeneralLogDataByDate(handle, startDate.Value, endDate.Value);
                }
                else
                {
                    // Load all data (same as "Read Log" button)
                    loadResult = FKAttendDLL.FK_LoadGeneralLogData(handle, 0); // 0 = read all data
                }

                if (loadResult != (int)enumErrorCode.RUN_SUCCESS)
                {
                    result.Message = $"Failed to load data. Error code: {loadResult}";
                    FKAttendDLL.FK_EnableDevice(handle, 1);
                    FKAttendDLL.FK_DisConnect(handle);
                    return result;
                }

                Console.WriteLine("✓ Data loaded successfully");

                // Step 4: Extract records (same as sample app logic)
                Console.WriteLine("Step 4: Extracting attendance records...");
                int recordCount = 0;

                // Check if device supports string IDs (same as sample app)
                int stringIdSupport = FKAttendDLL.FK_GetIsSupportStringID(handle);
                
                if (stringIdSupport >= (int)enumErrorCode.RUN_SUCCESS)
                {
                    // Use string ID version (same as sample app)
                    string enrollNumber = "";
                    int verifyMode = 0;
                    int inOutMode = 0;
                    DateTime logTime = DateTime.MinValue;
                    int workCode = 0;

                    do
                    {
                        // Initialize string buffer (same as sample app)
                        if (stringIdSupport == FKAttendDLL.USER_ID_LENGTH13_1)
                            enrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
                        else
                            enrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);

                        // Get record using string ID version (same as sample app)
                        int getResult = FKAttendDLL.FK_GetGeneralLogData_StringID_Workcode(
                            handle, ref enrollNumber, ref verifyMode, ref inOutMode, ref logTime, ref workCode);

                        if (getResult == (int)enumErrorCode.RUN_SUCCESS)
                        {
                            // Convert data to record
                            var record = new AttendanceRecord
                            {
                                UserId = enrollNumber.Trim(),
                                LogTime = logTime,
                                VerifyMode = GetVerifyModeString(verifyMode),
                                InOutMode = GetInOutModeString(inOutMode),
                                WorkCode = workCode
                            };

                            result.Records.Add(record);
                            recordCount++;

                            if (recordCount % 10 == 0)
                                Console.WriteLine($"  Extracted {recordCount} records...");
                        }
                        else if (getResult == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                        {
                            // No more data
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Error getting record {recordCount + 1}, code: {getResult}");
                            break;
                        }
                    } while (true);
                }
                else
                {
                    // Use numeric ID version (fallback)
                    UInt32 enrollNumber = 0;
                    int verifyMode = 0;
                    int inOutMode = 0;
                    DateTime logTime = DateTime.MinValue;
                    int workCode = 0;

                    do
                    {
                        int getResult = FKAttendDLL.FK_GetGeneralLogData(
                            handle, ref enrollNumber, ref verifyMode, ref inOutMode, ref logTime);

                        if (getResult == (int)enumErrorCode.RUN_SUCCESS)
                        {
                            var record = new AttendanceRecord
                            {
                                UserId = enrollNumber.ToString(),
                                LogTime = logTime,
                                VerifyMode = GetVerifyModeString(verifyMode),
                                InOutMode = GetInOutModeString(inOutMode),
                                WorkCode = workCode
                            };

                            result.Records.Add(record);
                            recordCount++;

                            if (recordCount % 10 == 0)
                                Console.WriteLine($"  Extracted {recordCount} records...");
                        }
                        else if (getResult == (int)enumErrorCode.RUNERR_DATAARRAY_END)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Error getting record {recordCount + 1}, code: {getResult}");
                            break;
                        }
                    } while (true);
                }

                // Step 5: Re-enable device and disconnect
                FKAttendDLL.FK_EnableDevice(handle, 1);
                FKAttendDLL.FK_DisConnect(handle);
                Console.WriteLine($"✓ Disconnected from device");

                // Set success
                result.Success = true;
                result.TotalRecords = recordCount;
                result.Message = $"Successfully extracted {recordCount} attendance records";

                Console.WriteLine($"✓ Extraction completed: {recordCount} records");

            }
            catch (Exception e)
            {
                result.Message = $"Error during extraction: {e.Message}";
                Console.WriteLine($"✗ Error: {e}");
            }

            return result;
        }

        private string GetVerifyModeString(int verifyMode)
        {
            switch (verifyMode)
            {
                case 1: return "Fingerprint";
                case 2: return "Password";
                case 3: return "Card";
                case 4: return "Fingerprint+Password";
                case 5: return "Card+Fingerprint";
                case 6: return "Password+Fingerprint";
                case 7: return "Card+Fingerprint";
                case 8: return "Job Number";
                case 9: return "Card+Password";
                case 20: return "Face";
                case 21: return "Face+Card";
                case 22: return "Face+Password";
                case 23: return "Card+Face";
                case 24: return "Password+Face";
                default: return "Unknown";
            }
        }

        private string GetInOutModeString(int inOutMode)
        {
            switch (inOutMode)
            {
                case 0: return "Check In";
                case 1: return "Check Out";
                case 2: return "Break Out";
                case 3: return "Break In";
                case 4: return "Overtime In";
                case 5: return "Overtime Out";
                default: return "Unknown";
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var config = new HttpSelfHostConfiguration("http://localhost:8080");
                
                config.MapHttpAttributeRoutes();
                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

                using (var server = new HttpSelfHostServer(config))
                {
                    server.OpenAsync().Wait();
                    Console.WriteLine("Attendance Data API Server is running on http://localhost:8080");
                    Console.WriteLine("Available endpoints:");
                    Console.WriteLine("  GET /api/attendance?startDate=2025-008-08&endDate=2025-08-09");
                    Console.WriteLine("  GET /api/attendance/all");
                    Console.WriteLine("  GET /api/device/status");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting server: {ex.Message}");
                Console.WriteLine("This might be due to missing Web API packages.");
                Console.WriteLine("Please ensure all required DLLs are copied from Execute&Dll folder.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    // Error code enumeration
    public enum enumErrorCode
    {
        RUN_SUCCESS = 1,
        RUNERR_NOSUPPORT = 0,
        RUNERR_UNKNOWNERROR = -1,
        RUNERR_NO_OPEN_COMM = -2,
        RUNERR_WRITE_FAIL = -3,
        RUNERR_READ_FAIL = -4,
        RUNERR_INVALID_PARAM = -5,
        RUNERR_NON_CARRYOUT = -6,
        RUNERR_DATAARRAY_END = -7,
        RUNERR_DATAARRAY_NONE = -8,
        RUNERR_MEMORY = -9,
        RUNERR_MIS_PASSWORD = -10,
        RUNERR_MEMORYOVER = -11,
        RUNERR_DATADOUBLE = -12,
        RUNERR_MANAGEROVER = -14,
        RUNERR_FPDATAVERSION = -15
    }

    // FKAttendDLL wrapper class
    public static class FKAttendDLL
    {
        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ConnectNet(
            int anMachineNo,
            string astrIpAddress,
            int anNetPort,
            int anTimeOut,
            int anProtocolType,
            int anNetPassword,
            int anLicense);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern void FK_DisConnect(int anHandleIndex);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EnableDevice(int anHandleIndex, byte anEnableFlag);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_LoadGeneralLogData(int anHandleIndex, int anReadMark);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_LoadGeneralLogDataByDate(int anHandleIndex, DateTime anStartDateTime, DateTime anEndDateTime);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGeneralLogData(
            int anHandleIndex,
            ref UInt32 apnEnrollNumber,
            ref int apnVerifyMode,
            ref int apnInOutMode,
            ref DateTime apnDateTime);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGeneralLogData_StringID_Workcode(
            int anHandleIndex,
            [MarshalAs(UnmanagedType.LPStr)] ref string apnEnrollNumber,
            ref int apnVerifyMode,
            ref int apnInOutMode,
            ref DateTime apnDateTime,
            ref int apnWorkCode);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetIsSupportStringID(int anHandleIndex);

        public const int USER_ID_LENGTH13_1 = 32;
        public const int USER_ID_LENGTH = 16;
    }
}

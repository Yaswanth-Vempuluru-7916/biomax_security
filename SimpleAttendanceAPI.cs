using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace SimpleAttendanceAPI
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

    public class SimpleAttendanceAPI
    {
        private const string DEVICE_IP = "10.67.20.120";
        private const int DEVICE_PORT = 5005;
        private const int MACHINE_NUMBER = 1;
        private const int PASSWORD = 0;
        private const int TIMEOUT = 5000;
        private const int LICENSE = 1261;
        private const int HTTP_PORT = 8080;

        private HttpListener listener;
        private bool isRunning = false;

        public void Start()
        {
            listener = new HttpListener();
            listener.Prefixes.Add($"http://localhost:{HTTP_PORT}/");
            listener.Start();
            isRunning = true;

            Console.WriteLine($"Simple Attendance API Server is running on http://localhost:{HTTP_PORT}");
            Console.WriteLine("Available endpoints:");
            Console.WriteLine($"  GET http://localhost:{HTTP_PORT}/api/attendance?startDate=2025-08-08&endDate=2025-08-09");
            Console.WriteLine($"  GET http://localhost:{HTTP_PORT}/api/attendance/all");
            Console.WriteLine($"  GET http://localhost:{HTTP_PORT}/api/device/status");
            Console.WriteLine("Press Ctrl+C to stop the server...");

            while (isRunning)
            {
                try
                {
                    HttpListenerContext context = listener.GetContext();
                    ProcessRequest(context);
                }
                catch (Exception ex)
                {
                    if (isRunning)
                    {
                        Console.WriteLine($"Error processing request: {ex.Message}");
                    }
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener?.Stop();
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            string path = context.Request.Url.AbsolutePath;
            string method = context.Request.HttpMethod;
            string query = context.Request.Url.Query;

            Console.WriteLine($"{DateTime.Now:HH:mm:ss} {method} {path}{query}");

            string response = "";
            string contentType = "application/json";

            try
            {
                if (path.StartsWith("/api/attendance"))
                {
                    if (path == "/api/attendance" || path == "/api/attendance/")
                    {
                        // Parse query parameters
                        DateTime? startDate = null;
                        DateTime? endDate = null;

                        if (!string.IsNullOrEmpty(query))
                        {
                            var queryParams = ParseQueryString(query);
                            if (queryParams.ContainsKey("startDate"))
                                DateTime.TryParse(queryParams["startDate"], out DateTime start);
                            if (queryParams.ContainsKey("endDate"))
                                DateTime.TryParse(queryParams["endDate"], out DateTime end);
                        }

                        var result = ExtractAttendanceData(startDate, endDate);
                        response = SerializeToJson(result);
                    }
                    else if (path == "/api/attendance/all")
                    {
                        var result = ExtractAttendanceData();
                        response = SerializeToJson(result);
                    }
                    else
                    {
                        response = "{\"error\": \"Invalid endpoint\"}";
                    }
                }
                else if (path == "/api/device/status")
                {
                    var status = GetDeviceStatus();
                    response = SerializeToJson(status);
                }
                else
                {
                    response = "{\"error\": \"Endpoint not found\"}";
                }
            }
            catch (Exception ex)
            {
                response = $"{{\"error\": \"{ex.Message}\"}}";
            }

            byte[] buffer = Encoding.UTF8.GetBytes(response);
            context.Response.ContentType = contentType;
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }

        private Dictionary<string, string> ParseQueryString(string query)
        {
            var result = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(query) || !query.StartsWith("?"))
                return result;

            query = query.Substring(1); // Remove the '?'
            var pairs = query.Split('&');
            foreach (var pair in pairs)
            {
                var keyValue = pair.Split('=');
                if (keyValue.Length == 2)
                {
                    result[keyValue[0]] = Uri.UnescapeDataString(keyValue[1]);
                }
            }
            return result;
        }

        private string SerializeToJson(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
            catch (Exception ex)
            {
                return $"{{\"error\": \"JSON serialization failed: {ex.Message}\"}}";
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

                // Step 2: Disable device during operation
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
                    loadResult = FKAttendDLL.FK_LoadGeneralLogDataByDate(handle, startDate.Value, endDate.Value);
                }
                else
                {
                    loadResult = FKAttendDLL.FK_LoadGeneralLogData(handle, 0);
                }

                if (loadResult != (int)enumErrorCode.RUN_SUCCESS)
                {
                    result.Message = $"Failed to load data. Error code: {loadResult}";
                    FKAttendDLL.FK_EnableDevice(handle, 1);
                    FKAttendDLL.FK_DisConnect(handle);
                    return result;
                }

                Console.WriteLine("✓ Data loaded successfully");

                // Step 4: Extract records
                Console.WriteLine("Step 4: Extracting attendance records...");
                int recordCount = 0;

                int stringIdSupport = FKAttendDLL.FK_GetIsSupportStringID(handle);
                
                if (stringIdSupport >= (int)enumErrorCode.RUN_SUCCESS)
                {
                    string enrollNumber = "";
                    int verifyMode = 0;
                    int inOutMode = 0;
                    DateTime logTime = DateTime.MinValue;
                    int workCode = 0;

                    do
                    {
                        if (stringIdSupport == FKAttendDLL.USER_ID_LENGTH13_1)
                            enrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
                        else
                            enrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);

                        int getResult = FKAttendDLL.FK_GetGeneralLogData_StringID_Workcode(
                            handle, ref enrollNumber, ref verifyMode, ref inOutMode, ref logTime, ref workCode);

                        if (getResult == (int)enumErrorCode.RUN_SUCCESS)
                        {
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

        private object GetDeviceStatus()
        {
            try
            {
                int handle = FKAttendDLL.FK_ConnectNet(
                    MACHINE_NUMBER,
                    DEVICE_IP,
                    DEVICE_PORT,
                    TIMEOUT,
                    0,
                    PASSWORD,
                    LICENSE
                );

                if (handle > 0)
                {
                    FKAttendDLL.FK_DisConnect(handle);
                    return new { Status = "Connected", Message = "Device is accessible" };
                }
                else
                {
                    return new { Status = "Disconnected", Message = $"Connection failed with error code: {handle}" };
                }
            }
            catch (Exception ex)
            {
                return new { Status = "Error", Message = ex.Message };
            }
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
            Console.WriteLine("Starting Simple Attendance API Server...");
            
            var api = new SimpleAttendanceAPI();
            
            // Handle Ctrl+C
            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                Console.WriteLine("\nStopping server...");
                api.Stop();
            };

            try
            {
                api.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting server: {ex.Message}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

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

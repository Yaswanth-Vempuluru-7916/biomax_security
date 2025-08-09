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
        // Raw integer values from device SDK
        public int VerifyMode { get; set; }
        public int InOutMode { get; set; }
        public int WorkCode { get; set; }
        
        // ADDED: Decoded string values for easy reading (optional)
        public string VerifyModeString { get; set; }
        public string InOutModeString { get; set; }
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
                            {
                                DateTime start;
                                if (DateTime.TryParse(queryParams["startDate"], out start))
                                {
                                    startDate = start;
                                    Console.WriteLine($"✓ Parsed startDate: {startDate:yyyy-MM-dd}");
                                }
                                else
                                {
                                    Console.WriteLine($"✗ Failed to parse startDate: {queryParams["startDate"]}");
                                }
                            }
                            if (queryParams.ContainsKey("endDate"))
                            {
                                DateTime end;
                                if (DateTime.TryParse(queryParams["endDate"], out end))
                                {
                                    endDate = end;
                                    Console.WriteLine($"✓ Parsed endDate: {endDate:yyyy-MM-dd}");
                                }
                                else
                                {
                                    Console.WriteLine($"✗ Failed to parse endDate: {queryParams["endDate"]}");
                                }
                            }
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
                    Console.WriteLine($"Loading data for date range: {startDate.Value:yyyy-MM-dd} to {endDate.Value:yyyy-MM-dd}");
                    loadResult = FKAttendDLL.FK_LoadGeneralLogDataByDate(handle, startDate.Value, endDate.Value);
                }
                else if (startDate.HasValue)
                {
                    // If only start date is provided, use it as both start and end date
                    Console.WriteLine($"Loading data for date: {startDate.Value:yyyy-MM-dd}");
                    loadResult = FKAttendDLL.FK_LoadGeneralLogDataByDate(handle, startDate.Value, startDate.Value);
                }
                else if (endDate.HasValue)
                {
                    // If only end date is provided, use it as both start and end date
                    Console.WriteLine($"Loading data for date: {endDate.Value:yyyy-MM-dd}");
                    loadResult = FKAttendDLL.FK_LoadGeneralLogDataByDate(handle, endDate.Value, endDate.Value);
                }
                else
                {
                    Console.WriteLine("Loading all attendance data (no date filter)");
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
                            // Store both raw values and decoded strings
                            var record = new AttendanceRecord
                            {
                                UserId = enrollNumber.Trim(),
                                LogTime = logTime,
                                VerifyMode = verifyMode,    // Raw bit-encoded integer
                                InOutMode = inOutMode,      // Raw bit-encoded integer  
                                WorkCode = workCode,
                                VerifyModeString = GetStringVerifyMode(verifyMode), // Decoded string
                                InOutModeString = GetStringInOutMode(inOutMode)     // Decoded string
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
                                VerifyMode = verifyMode,
                                InOutMode = inOutMode,
                                WorkCode = workCode,
                                VerifyModeString = GetStringVerifyMode(verifyMode),
                                InOutModeString = GetStringInOutMode(inOutMode)
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

        // ADDED: Methods to decode the actual device data format (based on FKAttend SDK)
        
        /// <summary>
        /// Decodes VerifyMode bit-encoded value to readable string (based on FKAttend SDK GetStringVerifyMode)
        /// </summary>
        private string GetStringVerifyMode(int nVerifyMode)
        {
            string result = "";
            int byteCount = 4;
            byte[] byteKind = BitConverter.GetBytes(nVerifyMode);
            
            for (int nIndex = byteCount - 1; nIndex >= 0; nIndex--)
            {
                int firstKind = byteKind[nIndex] & 0xF0;
                int secondKind = byteKind[nIndex] & 0x0F;
                firstKind = firstKind >> 4;
                
                if (firstKind == 0) break;
                
                if (nIndex < byteCount - 1)
                    result += "+";
                    
                switch (firstKind)
                {
                    case 1: result += "FP"; break;        // VK_FP
                    case 2: result += "PASS"; break;      // VK_PASS  
                    case 3: result += "CARD"; break;      // VK_CARD
                    case 4: result += "FACE"; break;      // VK_FACE
                    case 5: result += "FINGER VEIN"; break; // VK_FINGERVEIN
                    case 6: result += "IRIS"; break;      // VK_IRIS
                    case 7: result += "PALM VEIN"; break; // VK_PALMVEIN
                    case 8: result += "VOICE"; break;     // VK_VOICE
                }
                
                if (secondKind == 0) break;
                result += "+";
                
                switch (secondKind)
                {
                    case 1: result += "FP"; break;
                    case 2: result += "PASS"; break;
                    case 3: result += "CARD"; break;
                    case 4: result += "FACE"; break;
                    case 5: result += "FINGER VEIN"; break;
                    case 6: result += "IRIS"; break;
                    case 7: result += "PALM VEIN"; break;
                    case 8: result += "VOICE"; break;
                }
            }
            
            return string.IsNullOrEmpty(result) ? "--" : result;
        }
        
        /// <summary>
        /// Decodes InOutMode bit-encoded value (based on FKAttend SDK GetIoModeAndDoorMode)
        /// </summary>
        private string GetStringInOutMode(int nIoMode)
        {
            byte[] byteKind = BitConverter.GetBytes(nIoMode);
            
            // Extract the actual IO mode and In/Out flag
            int ioMode = byteKind[0] & 0x0f;
            int inOut = byteKind[0] >> 4;
            
            // Extract door mode (bytes 1-3)
            byte[] byteDoorMode = new byte[4];
            for (int nIndex = 0; nIndex < 3; nIndex++)
            {
                byteDoorMode[nIndex] = byteKind[nIndex + 1];
            }
            byteDoorMode[3] = 0;
            int doorMode = BitConverter.ToInt32(byteDoorMode, 0);
            
            // Create readable string
            string result = $"( {ioMode} )";
            
            // Add door mode description
            switch (doorMode)
            {
                case 1: result += "&( Close door )"; break;
                case 2: result += "&( Open door )"; break;
                case 3: result += "&( Prog Open )"; break;
                case 4: result += "&( Prog Close )"; break;
                case 5: result += "&( Illegal Open )"; break;
                case 6: result += "&( Illegal Close )"; break;
                case 9: result += "&( Open door )"; break;
                default: result += $"&( Door {doorMode} )"; break;
            }
            
            // Add In/Out description
            switch (inOut)
            {
                case 0: result += "&( In )"; break;
                case 1: result += "&( Out )"; break;
                default: result += $"&( {inOut} )"; break;
            }
            
            return result;
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
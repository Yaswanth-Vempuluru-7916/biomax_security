using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;

namespace DirectDataExtractor
{
    public class AttendanceRecord
    {
        public string UserId { get; set; }
        public string VerifyMode { get; set; }
        public string InOutMode { get; set; }
        public DateTime LogTime { get; set; }
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

    class Program
    {
        // Device configuration
        private static string DEVICE_IP = "10.67.20.120";
        private static int DEVICE_PORT = 5005;
        private static int MACHINE_NUMBER = 1;
        private static int PASSWORD = 0;
        private static int TIMEOUT = 5000;
        private static int LICENSE = 1261;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Direct Attendance Data Extractor ===");
            Console.WriteLine($"Connecting to device: {DEVICE_IP}:{DEVICE_PORT}");
            Console.WriteLine();

            var result = ExtractAttendanceData();

            // Output JSON
            string jsonOutput = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine("=== JSON OUTPUT ===");
            Console.WriteLine(jsonOutput);

            // Also save to file
            System.IO.File.WriteAllText("attendance_data.json", jsonOutput);
            Console.WriteLine();
            Console.WriteLine("Data also saved to: attendance_data.json");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static ExtractionResult ExtractAttendanceData()
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
                    1, // PROTOCOL_TCPIP
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
                int loadResult = FKAttendDLL.FK_LoadGeneralLogData(handle, 0); // 0 = read all data
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

                // Check if device supports string IDs
                int stringIdSupport = FKAttendDLL.FK_GetLogDataIsSupportStringID(handle);

                UInt32 enrollNumber = 0;
                int verifyMode = 0;
                int inOutMode = 0;
                DateTime logTime = DateTime.MinValue;
                int workCode = 0;

                do
                {
                    int getResult;
                    if (stringIdSupport >= (int)enumErrorCode.RUN_SUCCESS)
                    {
                        // String ID support
                        string enrollNumberStr = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
                        getResult = FKAttendDLL.FK_GetGeneralLogData_StringID(handle, ref enrollNumberStr, ref verifyMode, ref inOutMode, ref logTime, ref workCode);
                        
                        if (getResult == (int)enumErrorCode.RUN_SUCCESS)
                        {
                            var record = new AttendanceRecord
                            {
                                UserId = enrollNumberStr.Trim(),
                                VerifyMode = GetVerifyModeString(verifyMode),
                                InOutMode = GetInOutModeString(inOutMode),
                                LogTime = logTime,
                                WorkCode = workCode
                            };
                            result.Records.Add(record);
                            recordCount++;
                        }
                    }
                    else
                    {
                        // Numeric ID support
                        getResult = FKAttendDLL.FK_GetGeneralLogData(handle, ref enrollNumber, ref verifyMode, ref inOutMode, ref logTime, ref workCode);
                        
                        if (getResult == (int)enumErrorCode.RUN_SUCCESS)
                        {
                            var record = new AttendanceRecord
                            {
                                UserId = enrollNumber.ToString(),
                                VerifyMode = GetVerifyModeString(verifyMode),
                                InOutMode = GetInOutModeString(inOutMode),
                                LogTime = logTime,
                                WorkCode = workCode
                            };
                            result.Records.Add(record);
                            recordCount++;
                        }
                    }
                } while (getResult == (int)enumErrorCode.RUN_SUCCESS);

                // Step 5: Re-enable device
                Console.WriteLine("Step 5: Re-enabling device...");
                FKAttendDLL.FK_EnableDevice(handle, 1);

                // Step 6: Disconnect
                Console.WriteLine("Step 6: Disconnecting from device...");
                FKAttendDLL.FK_DisConnect(handle);

                // Success!
                result.Success = true;
                result.TotalRecords = recordCount;
                result.Message = $"Successfully extracted {recordCount} attendance records";

                Console.WriteLine($"✓ Extraction completed! Found {recordCount} records");

            }
            catch (Exception ex)
            {
                result.Message = $"Error during extraction: {ex.Message}";
                Console.WriteLine($"✗ Error: {ex.Message}");
            }

            return result;
        }

        static string GetVerifyModeString(int verifyMode)
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

        static string GetInOutModeString(int inOutMode)
        {
            switch (inOutMode)
            {
                case 0: return "Check In";
                case 1: return "Check Out";
                default: return "Unknown";
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
        public static extern int FK_GetGeneralLogData(
            int anHandleIndex,
            ref UInt32 apnEnrollNumber,
            ref int apnVerifyMode,
            ref int apnInOutMode,
            ref DateTime apnDateTime,
            ref int apnWorkCode);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGeneralLogData_StringID(
            int anHandleIndex,
            ref string apstrEnrollNumber,
            ref int apnVerifyMode,
            ref int apnInOutMode,
            ref DateTime apnDateTime,
            ref int apnWorkCode);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetIsSupportStringID(int anHandleIndex);

        [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetLogDataIsSupportStringID(int anHandleIndex);

        public const int USER_ID_LENGTH13_1 = 13;
    }
}

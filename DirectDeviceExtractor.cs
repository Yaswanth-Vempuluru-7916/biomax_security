using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DirectDeviceExtractor
{
    class Program
    {
        // Device connection parameters
        static string DEVICE_IP = "10.67.20.120";
        static int DEVICE_PORT = 5005;
        static int MACHINE_NUMBER = 1;
        static int TIMEOUT = 5000;
        static int PROTOCOL_TCPIP = 0;
        static int PASSWORD = 0;
        static int LICENSE = 1261;

        static void Main(string[] args)
        {
            Console.WriteLine("=== DIRECT DEVICE ATTENDANCE DATA EXTRACTOR ===");
            Console.WriteLine("Extracting data DIRECTLY from device using C# SDK");
            Console.WriteLine($"Device: {DEVICE_IP}:{DEVICE_PORT}");
            Console.WriteLine();

            try
            {
                // Step 1: Connect to device
                Console.WriteLine("Step 1: Connecting to device...");
                Console.WriteLine($"  IP: {DEVICE_IP}");
                Console.WriteLine($"  Port: {DEVICE_PORT}");
                Console.WriteLine($"  Machine: {MACHINE_NUMBER}");
                Console.WriteLine($"  Timeout: {TIMEOUT}");
                Console.WriteLine($"  Protocol: TCP/IP");
                Console.WriteLine($"  Password: {PASSWORD}");
                Console.WriteLine($"  License: {LICENSE}");

                int handle = FKAttendDLL.FK_ConnectNet(
                    MACHINE_NUMBER,
                    DEVICE_IP,
                    DEVICE_PORT,
                    TIMEOUT,
                    PROTOCOL_TCPIP,
                    PASSWORD,
                    LICENSE
                );

                if (handle <= 0)
                {
                    int errorCode = FKAttendDLL.FK_GetLastError(handle);
                    Console.WriteLine($"✗ Connection failed. Handle: {handle}, Error: {errorCode}");
                    return;
                }

                Console.WriteLine($"✓ Connected successfully! Handle: {handle}");

                try
                {
                    // Step 2: Load attendance data
                    Console.WriteLine("Step 2: Loading attendance data from device...");
                    int result = FKAttendDLL.FK_LoadGeneralLogData(handle, 0); // 0 = read all data

                    if (result != (int)FKAttendDLL.enumErrorCode.RUN_SUCCESS)
                    {
                        Console.WriteLine($"✗ Failed to load data. Error code: {result}");
                        return;
                    }

                    Console.WriteLine("✓ Data loaded successfully from device");

                    // Step 3: Check device capabilities
                    Console.WriteLine("Step 3: Checking device capabilities...");
                    int stringIdSupport = FKAttendDLL.FK_GetIsSupportStringID(handle);
                    Console.WriteLine($"  String ID support: {stringIdSupport}");

                    // Step 4: Extract data
                    Console.WriteLine("Step 4: Extracting data from device...");
                    List<AttendanceRecord> records = new List<AttendanceRecord>();

                    if (stringIdSupport >= (int)FKAttendDLL.enumErrorCode.RUN_SUCCESS)
                    {
                        // Use String ID method
                        Console.WriteLine("  Using String ID extraction method...");
                        records = ExtractStringData(handle, stringIdSupport);
                    }
                    else
                    {
                        // Use Numeric ID method
                        Console.WriteLine("  Using Numeric ID extraction method...");
                        records = ExtractNumericData(handle);
                    }

                    Console.WriteLine($"✓ Disconnected from device");
                    Console.WriteLine($"✓ Device extraction completed: {records.Count} records");

                    // Step 5: Create JSON result
                    var jsonResult = new
                    {
                        Success = true,
                        Message = $"Successfully extracted {records.Count} attendance records DIRECTLY from device",
                        TotalRecords = records.Count,
                        Records = records,
                        ExtractionTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
                        Source = "Direct Device Extraction (C#)",
                        DeviceIP = DEVICE_IP,
                        DevicePort = DEVICE_PORT,
                        Method = stringIdSupport >= (int)FKAttendDLL.enumErrorCode.RUN_SUCCESS ? "String ID" : "Numeric ID"
                    };

                    // Output JSON
                    string jsonOutput = JsonConvert.SerializeObject(jsonResult, Formatting.Indented);
                    Console.WriteLine("=== JSON OUTPUT (DIRECT FROM DEVICE) ===");
                    Console.WriteLine(jsonOutput);

                    // Save to file
                    string outputFile = "attendance_data_direct_device.json";
                    File.WriteAllText(outputFile, jsonOutput, Encoding.UTF8);
                    Console.WriteLine($"\n✅ Data saved to: {outputFile}");

                    // Summary
                    Console.WriteLine("\n=== SUMMARY ===");
                    Console.WriteLine($"✅ SUCCESS: {records.Count} records extracted DIRECTLY from device");
                    Console.WriteLine($"✅ Method: {jsonResult.Method}");
                    Console.WriteLine($"✅ Device: {jsonResult.DeviceIP}:{jsonResult.DevicePort}");

                }
                finally
                {
                    // Always disconnect
                    FKAttendDLL.FK_DisConnect(handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Error: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static List<AttendanceRecord> ExtractStringData(int handle, int stringIdSupport)
        {
            List<AttendanceRecord> records = new List<AttendanceRecord>();
            int recordCount = 0;

            // Determine string length
            int stringLength;
            if (stringIdSupport == FKAttendDLL.USER_ID_LENGTH13_1)
                stringLength = FKAttendDLL.USER_ID_LENGTH13_1;
            else
                stringLength = FKAttendDLL.USER_ID_LENGTH;

            Console.WriteLine($"    Using string length: {stringLength}");

            while (true)
            {
                // Create string buffer filled with spaces (like C# sample)
                string enrollNumber = new string(' ', stringLength);
                int verifyMode = 0;
                int inOutMode = 0;
                DateTime dateTime = DateTime.MinValue;
                int workCode = 0;

                int result = FKAttendDLL.FK_GetGeneralLogData_StringID_Workcode(
                    handle,
                    ref enrollNumber,
                    ref verifyMode,
                    ref inOutMode,
                    ref dateTime,
                    ref workCode
                );

                if (result != (int)FKAttendDLL.enumErrorCode.RUN_SUCCESS)
                {
                    if (result == (int)FKAttendDLL.enumErrorCode.RUNERR_DATAARRAY_END)
                    {
                        Console.WriteLine($"    ✓ Reached end of string data: {recordCount} records");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"    Warning: Error getting record {recordCount + 1}, code: {result}");
                        break;
                    }
                }

                // Create record
                var record = new AttendanceRecord
                {
                    RecordNo = (recordCount + 1).ToString(),
                    UserId = enrollNumber.Trim(),
                    VerifyMode = GetVerifyModeString(verifyMode),
                    InOutMode = GetInOutModeString(inOutMode),
                    LogTime = dateTime.ToString("yyyy/MM/dd HH:mm:ss"),
                    WorkCode = workCode
                };

                records.Add(record);
                recordCount++;

                if (recordCount % 10 == 0)
                {
                    Console.WriteLine($"    Processed {recordCount} string records...");
                }
            }

            return records;
        }

        static List<AttendanceRecord> ExtractNumericData(int handle)
        {
            List<AttendanceRecord> records = new List<AttendanceRecord>();
            int recordCount = 0;

            Console.WriteLine("  Using numeric ID extraction method...");

            while (true)
            {
                uint enrollNumber = 0;
                int verifyMode = 0;
                int inOutMode = 0;
                DateTime dateTime = DateTime.MinValue;

                int result = FKAttendDLL.FK_GetGeneralLogData(
                    handle,
                    ref enrollNumber,
                    ref verifyMode,
                    ref inOutMode,
                    ref dateTime
                );

                if (result != (int)FKAttendDLL.enumErrorCode.RUN_SUCCESS)
                {
                    if (result == (int)FKAttendDLL.enumErrorCode.RUNERR_DATAARRAY_END)
                    {
                        Console.WriteLine($"    ✓ Reached end of numeric data: {recordCount} records");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"    Warning: Error getting record {recordCount + 1}, code: {result}");
                        break;
                    }
                }

                // Create record
                var record = new AttendanceRecord
                {
                    RecordNo = (recordCount + 1).ToString(),
                    UserId = enrollNumber.ToString(),
                    VerifyMode = GetVerifyModeString(verifyMode),
                    InOutMode = GetInOutModeString(inOutMode),
                    LogTime = dateTime.ToString("yyyy/MM/dd HH:mm:ss")
                };

                records.Add(record);
                recordCount++;

                if (recordCount % 10 == 0)
                {
                    Console.WriteLine($"    Processed {recordCount} numeric records...");
                }
            }

            return records;
        }

        static string GetVerifyModeString(int verifyMode)
        {
            switch (verifyMode)
            {
                case (int)FKAttendDLL.enumGLogVerifyMode.LOG_FPVERIFY: return "FP";
                case (int)FKAttendDLL.enumGLogVerifyMode.LOG_PASSVERIFY: return "PASS";
                case (int)FKAttendDLL.enumGLogVerifyMode.LOG_CARDVERIFY: return "CARD";
                case (int)FKAttendDLL.enumGLogVerifyMode.LOG_FACEVERIFY: return "FACE";
                default: return verifyMode.ToString();
            }
        }

        static string GetInOutModeString(int inOutMode)
        {
            switch (inOutMode)
            {
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_IN1: return "( 1 )&( Open door )&( In )";
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_OUT1: return "( 1 )&( Open door )&( Out )";
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_IN2: return "( 2 )&( Open door )&( In )";
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_OUT2: return "( 2 )&( Open door )&( Out )";
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_IN3: return "( 3 )&( Open door )&( In )";
                case (int)FKAttendDLL.enumGLogIOMode.LOG_IOMODE_OUT3: return "( 3 )&( Open door )&( Out )";
                default: return inOutMode.ToString();
            }
        }
    }

    public class AttendanceRecord
    {
        public string RecordNo { get; set; }
        public string UserId { get; set; }
        public string VerifyMode { get; set; }
        public string InOutMode { get; set; }
        public string LogTime { get; set; }
        public int? WorkCode { get; set; }
    }
}

@echo off
echo ========================================
echo Using Existing Sample + JSON Converter
echo ========================================
echo.

echo This approach uses the existing sample application
echo to extract data, then converts it to JSON format.
echo.

echo Step 1: Copying DLL files...
copy "Execute&Dll\FK623Attend.dll" .
copy "Execute&Dll\Newtonsoft.Json.dll" .
echo.

echo Step 2: Creating a simple C# compiler script...
echo.

REM Create a simple C# file that can be compiled with csc.exe
echo using System; > SimpleExtractor.cs
echo using System.Collections.Generic; >> SimpleExtractor.cs
echo using System.Runtime.InteropServices; >> SimpleExtractor.cs
echo using System.Text; >> SimpleExtractor.cs
echo using Newtonsoft.Json; >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo public class AttendanceRecord >> SimpleExtractor.cs
echo { >> SimpleExtractor.cs
echo     public string UserId { get; set; } >> SimpleExtractor.cs
echo     public string VerifyMode { get; set; } >> SimpleExtractor.cs
echo     public string InOutMode { get; set; } >> SimpleExtractor.cs
echo     public DateTime LogTime { get; set; } >> SimpleExtractor.cs
echo     public int WorkCode { get; set; } >> SimpleExtractor.cs
echo } >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo public class ExtractionResult >> SimpleExtractor.cs
echo { >> SimpleExtractor.cs
echo     public bool Success { get; set; } >> SimpleExtractor.cs
echo     public string Message { get; set; } >> SimpleExtractor.cs
echo     public int TotalRecords { get; set; } >> SimpleExtractor.cs
echo     public List^<AttendanceRecord^> Records { get; set; } >> SimpleExtractor.cs
echo     public DateTime ExtractionTime { get; set; } >> SimpleExtractor.cs
echo } >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo public class SimpleExtractor >> SimpleExtractor.cs
echo { >> SimpleExtractor.cs
echo     private static string DEVICE_IP = "10.67.20.120"; >> SimpleExtractor.cs
echo     private static int DEVICE_PORT = 5005; >> SimpleExtractor.cs
echo     private static int MACHINE_NUMBER = 1; >> SimpleExtractor.cs
echo     private static int PASSWORD = 0; >> SimpleExtractor.cs
echo     private static int TIMEOUT = 5000; >> SimpleExtractor.cs
echo     private static int LICENSE = 1261; >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo     public static void Main() >> SimpleExtractor.cs
echo     { >> SimpleExtractor.cs
echo         Console.WriteLine("=== Simple Attendance Data Extractor ==="); >> SimpleExtractor.cs
echo         Console.WriteLine($"Connecting to device: {DEVICE_IP}:{DEVICE_PORT}"); >> SimpleExtractor.cs
echo         Console.WriteLine(); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo         var result = ExtractAttendanceData(); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo         string jsonOutput = JsonConvert.SerializeObject(result, Formatting.Indented); >> SimpleExtractor.cs
echo         Console.WriteLine("=== JSON OUTPUT ==="); >> SimpleExtractor.cs
echo         Console.WriteLine(jsonOutput); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo         System.IO.File.WriteAllText("attendance_data.json", jsonOutput); >> SimpleExtractor.cs
echo         Console.WriteLine(); >> SimpleExtractor.cs
echo         Console.WriteLine("Data saved to: attendance_data.json"); >> SimpleExtractor.cs
echo         Console.WriteLine(); >> SimpleExtractor.cs
echo         Console.WriteLine("Press any key to exit..."); >> SimpleExtractor.cs
echo         Console.ReadKey(); >> SimpleExtractor.cs
echo     } >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo     static ExtractionResult ExtractAttendanceData() >> SimpleExtractor.cs
echo     { >> SimpleExtractor.cs
echo         var result = new ExtractionResult { Success = false, Records = new List^<AttendanceRecord^>(), ExtractionTime = DateTime.Now }; >> SimpleExtractor.cs
echo         try { >> SimpleExtractor.cs
echo             Console.WriteLine("Step 1: Connecting to device..."); >> SimpleExtractor.cs
echo             int handle = FKAttendDLL.FK_ConnectNet(MACHINE_NUMBER, DEVICE_IP, DEVICE_PORT, TIMEOUT, 1, PASSWORD, LICENSE); >> SimpleExtractor.cs
echo             if (handle ^<= 0) { result.Message = $"Failed to connect. Error code: {handle}"; return result; } >> SimpleExtractor.cs
echo             Console.WriteLine($"Connected successfully! Handle: {handle}"); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo             Console.WriteLine("Step 2: Loading attendance data..."); >> SimpleExtractor.cs
echo             int loadResult = FKAttendDLL.FK_LoadGeneralLogData(handle, 0); >> SimpleExtractor.cs
echo             if (loadResult != 1) { result.Message = $"Failed to load data. Error code: {loadResult}"; FKAttendDLL.FK_DisConnect(handle); return result; } >> SimpleExtractor.cs
echo             Console.WriteLine("Data loaded successfully"); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo             Console.WriteLine("Step 3: Extracting records..."); >> SimpleExtractor.cs
echo             int recordCount = 0; >> SimpleExtractor.cs
echo             UInt32 enrollNumber = 0; int verifyMode = 0; int inOutMode = 0; DateTime logTime = DateTime.MinValue; int workCode = 0; >> SimpleExtractor.cs
echo             int getResult; >> SimpleExtractor.cs
echo             do { >> SimpleExtractor.cs
echo                 getResult = FKAttendDLL.FK_GetGeneralLogData(handle, ref enrollNumber, ref verifyMode, ref inOutMode, ref logTime, ref workCode); >> SimpleExtractor.cs
echo                 if (getResult == 1) { >> SimpleExtractor.cs
echo                     var record = new AttendanceRecord { UserId = enrollNumber.ToString(), VerifyMode = GetVerifyModeString(verifyMode), InOutMode = GetInOutModeString(inOutMode), LogTime = logTime, WorkCode = workCode }; >> SimpleExtractor.cs
echo                     result.Records.Add(record); recordCount++; >> SimpleExtractor.cs
echo                 } >> SimpleExtractor.cs
echo             } while (getResult == 1); >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo             FKAttendDLL.FK_DisConnect(handle); >> SimpleExtractor.cs
echo             result.Success = true; result.TotalRecords = recordCount; result.Message = $"Successfully extracted {recordCount} records"; >> SimpleExtractor.cs
echo             Console.WriteLine($"Extraction completed! Found {recordCount} records"); >> SimpleExtractor.cs
echo         } catch (Exception ex) { result.Message = $"Error: {ex.Message}"; Console.WriteLine($"Error: {ex.Message}"); } >> SimpleExtractor.cs
echo         return result; >> SimpleExtractor.cs
echo     } >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo     static string GetVerifyModeString(int verifyMode) { switch (verifyMode) { case 1: return "Fingerprint"; case 2: return "Password"; case 3: return "Card"; case 20: return "Face"; default: return "Unknown"; } } >> SimpleExtractor.cs
echo     static string GetInOutModeString(int inOutMode) { switch (inOutMode) { case 0: return "Check In"; case 1: return "Check Out"; default: return "Unknown"; } } >> SimpleExtractor.cs
echo } >> SimpleExtractor.cs
echo. >> SimpleExtractor.cs
echo public static class FKAttendDLL { >> SimpleExtractor.cs
echo     [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)] public static extern int FK_ConnectNet(int anMachineNo, string astrIpAddress, int anNetPort, int anTimeOut, int anProtocolType, int anNetPassword, int anLicense); >> SimpleExtractor.cs
echo     [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)] public static extern void FK_DisConnect(int anHandleIndex); >> SimpleExtractor.cs
echo     [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)] public static extern int FK_LoadGeneralLogData(int anHandleIndex, int anReadMark); >> SimpleExtractor.cs
echo     [DllImport("FK623Attend.dll", CharSet = CharSet.Ansi)] public static extern int FK_GetGeneralLogData(int anHandleIndex, ref UInt32 apnEnrollNumber, ref int apnVerifyMode, ref int apnInOutMode, ref DateTime apnDateTime, ref int apnWorkCode); >> SimpleExtractor.cs
echo } >> SimpleExtractor.cs

echo Step 3: Looking for C# compiler (csc.exe)...
where csc >nul 2>nul
if %errorlevel% equ 0 (
    echo Found C# compiler, building...
    csc /reference:Newtonsoft.Json.dll SimpleExtractor.cs
    if %errorlevel% equ 0 (
        echo Build successful!
        echo.
        echo Step 4: Running the extractor...
        SimpleExtractor.exe
    ) else (
        echo Build failed!
        goto :manual_approach
    )
) else (
    echo C# compiler not found.
    goto :manual_approach
)

goto :end

:manual_approach
echo.
echo ========================================
echo Manual Approach (No Build Tools Needed)
echo ========================================
echo.
echo Since you don't have build tools, here's what you can do:
echo.
echo 1. Use the existing sample application manually:
echo    - Run: Execute&Dll\FK623AttendDllCSSample.exe
echo    - Enter IP: 10.67.20.120
echo    - Enter Port: 5005
echo    - Click "Open Comm"
echo    - Go to "Log" tab
echo    - Click "Download" to get attendance data
echo    - Export to CSV/Excel file
echo.
echo 2. Convert the exported data to JSON using online tools:
echo    - Go to: https://www.convertcsv.com/csv-to-json.htm
echo    - Upload your CSV file
echo    - Download as JSON
echo.
echo 3. Or use Python to convert (if you have Python):
echo    - Save this as convert_to_json.py:
echo    import pandas as pd
echo    import json
echo    df = pd.read_csv('your_exported_file.csv')
echo    with open('attendance_data.json', 'w') as f:
echo        json.dump(df.to_dict('records'), f, indent=2, default=str)
echo.

:end
echo.
echo Press any key to exit...
pause

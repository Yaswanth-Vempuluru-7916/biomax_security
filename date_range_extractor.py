import ctypes
import ctypes.wintypes
import json
import os
import sys
from datetime import datetime

# Load the DLL
try:
    dll_path = os.path.join(os.path.dirname(__file__), "FK623Attend.dll")
    fk_dll = ctypes.CDLL(dll_path)
    print(f"✓ FK623Attend.dll loaded successfully from: {dll_path}")
except Exception as e:
    print(f"✗ Failed to load FK623Attend.dll: {e}")
    print("Make sure FK623Attend.dll is in the same directory as this script")
    sys.exit(1)

# Device connection parameters (same as sample app)
DEVICE_IP = "10.67.20.120"
DEVICE_PORT = 5005
MACHINE_NUMBER = 1
TIMEOUT = 5000
PROTOCOL_TCPIP = 0  # Same as sample app
PASSWORD = 0
LICENSE = 1261

# Error codes (from FKAttendDLL.cs)
class enumErrorCode:
    RUN_SUCCESS = 1
    RUNERR_NOSUPPORT = 0
    RUNERR_UNKNOWNERROR = -1
    RUNERR_NO_OPEN_COMM = -2
    RUNERR_WRITE_FAIL = -3
    RUNERR_READ_FAIL = -4
    RUNERR_INVALID_PARAM = -5
    RUNERR_NON_CARRYOUT = -6
    RUNERR_DATAARRAY_END = -7
    RUNERR_DATAARRAY_NONE = -8

# Verify mode constants
class enumGLogVerifyMode:
    LOG_FPVERIFY = 1
    LOG_PASSVERIFY = 2
    LOG_CARDVERIFY = 3
    LOG_FACEVERIFY = 20

# In/Out mode constants
class enumGLogIOMode:
    LOG_IOMODE_IN1 = 1
    LOG_IOMODE_OUT1 = 2
    LOG_IOMODE_IN2 = 3
    LOG_IOMODE_OUT2 = 4
    LOG_IOMODE_IN3 = 5
    LOG_IOMODE_OUT3 = 6

def parse_date_string(date_str):
    """Parse date string in YYYY/MM/DD HH:MM:SS format to DateTime object"""
    try:
        # Parse the date string in your preferred format
        dt = datetime.strptime(date_str, "%Y/%m/%d %H:%M:%S")
        return dt
    except ValueError as e:
        print(f"✗ Invalid date format: {date_str}")
        print("Expected format: YYYY/MM/DD HH:MM:SS (e.g., 2025/08/06 08:25:22)")
        return None

def get_verify_mode_string(verify_mode):
    """Same mapping as sample app"""
    if verify_mode == enumGLogVerifyMode.LOG_FPVERIFY:
        return "FP"
    elif verify_mode == enumGLogVerifyMode.LOG_PASSVERIFY:
        return "PASS"
    elif verify_mode == enumGLogVerifyMode.LOG_CARDVERIFY:
        return "CARD"
    elif verify_mode == enumGLogVerifyMode.LOG_FACEVERIFY:
        return "FACE"
    else:
        return str(verify_mode)

def get_inout_mode_string(inout_mode):
    """Same mapping as sample app"""
    if inout_mode == enumGLogIOMode.LOG_IOMODE_IN1:
        return "( 1 )&( Open door )&( In )"
    elif inout_mode == enumGLogIOMode.LOG_IOMODE_OUT1:
        return "( 1 )&( Open door )&( Out )"
    elif inout_mode == enumGLogIOMode.LOG_IOMODE_IN2:
        return "( 2 )&( Open door )&( In )"
    elif inout_mode == enumGLogIOMode.LOG_IOMODE_OUT2:
        return "( 2 )&( Open door )&( Out )"
    elif inout_mode == enumGLogIOMode.LOG_IOMODE_IN3:
        return "( 3 )&( Open door )&( In )"
    elif inout_mode == enumGLogIOMode.LOG_IOMODE_OUT3:
        return "( 3 )&( Open door )&( Out )"
    else:
        return str(inout_mode)

def convert_datetime_to_string(dt_value):
    """Convert datetime value to string format (same as sample app)"""
    # The datetime value is a 32-bit integer in YYYYMMDDHHMMSS format
    dt_str = str(dt_value).zfill(14)
    if len(dt_str) == 14:
        year = dt_str[0:4]
        month = dt_str[4:6]
        day = dt_str[6:8]
        hour = dt_str[8:10]
        minute = dt_str[10:12]
        second = dt_str[12:14]
        return f"{year}/{month}/{day} {hour}:{minute}:{second}"
    else:
        return "Invalid Date"

def main():
    print("=== DATE RANGE ATTENDANCE EXTRACTOR ===")
    print("Extract attendance data for specific date range")
    print(f"Device: {DEVICE_IP}:{DEVICE_PORT}")
    print()
    
    # Get date range from user
    print("Enter date range in YYYY/MM/DD HH:MM:SS format:")
    print("Example: 2025/08/06 08:25:22")
    print()
    
    start_date_str = input("Start Date (YYYY/MM/DD HH:MM:SS): ").strip()
    end_date_str = input("End Date (YYYY/MM/DD HH:MM:SS): ").strip()
    
    # Parse dates
    start_date = parse_date_string(start_date_str)
    end_date = parse_date_string(end_date_str)
    
    if start_date is None or end_date is None:
        return
    
    print(f"\nExtracting data from: {start_date_str} to {end_date_str}")
    print()

    # Step 1: Connect to device (same as "Open Comm" button)
    print("Step 1: Connecting to device (Open Comm)...")
    print(f"  IP: {DEVICE_IP}")
    print(f"  Port: {DEVICE_PORT}")
    print(f"  Machine: {MACHINE_NUMBER}")
    print(f"  Timeout: {TIMEOUT}")
    print(f"  Protocol: TCP/IP")
    print(f"  Password: {PASSWORD}")
    print(f"  License: {LICENSE}")

    # Set function signatures (same as sample app)
    fk_dll.FK_ConnectNet.argtypes = [
        ctypes.c_int,      # MachineNumber
        ctypes.c_char_p,   # IP
        ctypes.c_int,      # Port
        ctypes.c_int,      # Timeout
        ctypes.c_int,      # Protocol
        ctypes.c_int,      # Password
        ctypes.c_int       # License
    ]
    fk_dll.FK_ConnectNet.restype = ctypes.c_int

    # Define DateTime structure for C# DateTime
    class DateTime(ctypes.Structure):
        _fields_ = [
            ("year", ctypes.c_int),
            ("month", ctypes.c_int),
            ("day", ctypes.c_int),
            ("hour", ctypes.c_int),
            ("minute", ctypes.c_int),
            ("second", ctypes.c_int),
            ("millisecond", ctypes.c_int)
        ]

    fk_dll.FK_LoadGeneralLogDataByDate.argtypes = [
        ctypes.c_int,      # Handle
        DateTime,          # StartDateTime
        DateTime          # EndDateTime
    ]
    fk_dll.FK_LoadGeneralLogDataByDate.restype = ctypes.c_int

    fk_dll.FK_GetGeneralLogData.argtypes = [
        ctypes.c_int,                          # Handle
        ctypes.POINTER(ctypes.c_uint32),       # EnrollNumber
        ctypes.POINTER(ctypes.c_int),          # VerifyMode
        ctypes.POINTER(ctypes.c_int),          # InOutMode
        ctypes.POINTER(ctypes.c_uint32)        # DateTime
    ]
    fk_dll.FK_GetGeneralLogData.restype = ctypes.c_int

    fk_dll.FK_DisConnect.argtypes = [ctypes.c_int]
    fk_dll.FK_DisConnect.restype = ctypes.c_int

    # Connect to device
    handle = fk_dll.FK_ConnectNet(
        MACHINE_NUMBER,
        DEVICE_IP.encode('ascii'),
        DEVICE_PORT,
        TIMEOUT,
        PROTOCOL_TCPIP,
        PASSWORD,
        LICENSE
    )

    if handle <= 0:
        print(f"✗ Connection failed. Handle: {handle}")
        return

    print(f"✓ Connected successfully! Handle: {handle}")

    try:
        # Step 2: Load attendance data by date range (same as "Read Log by Date" button)
        print("Step 2: Loading attendance data by date range...")
        
        # Create DateTime structures
        start_dt = DateTime(
            start_date.year, start_date.month, start_date.day,
            start_date.hour, start_date.minute, start_date.second, 0
        )
        end_dt = DateTime(
            end_date.year, end_date.month, end_date.day,
            end_date.hour, end_date.minute, end_date.second, 0
        )
        
        print(f"  Start Date: {start_date_str}")
        print(f"  End Date: {end_date_str}")
        
        result = fk_dll.FK_LoadGeneralLogDataByDate(handle, start_dt, end_dt)

        if result != enumErrorCode.RUN_SUCCESS:
            print(f"✗ Failed to load data by date. Error code: {result}")
            return

        print("✓ Data loaded successfully from device for specified date range")

        # Step 3: Extract data using NUMERIC ID method only (avoids string buffer issues)
        print("Step 3: Extracting attendance records (Numeric ID method)...")
        records = []
        record_count = 0

        while True:
            enroll_number = ctypes.c_uint32(0)
            verify_mode = ctypes.c_int(0)
            inout_mode = ctypes.c_int(0)
            date_time = ctypes.c_uint32(0)

            # Call the same function as sample app (numeric version)
            result = fk_dll.FK_GetGeneralLogData(
                handle,
                ctypes.byref(enroll_number),
                ctypes.byref(verify_mode),
                ctypes.byref(inout_mode),
                ctypes.byref(date_time)
            )

            if result != enumErrorCode.RUN_SUCCESS:
                if result == enumErrorCode.RUNERR_DATAARRAY_END:
                    print(f"    ✓ Reached end of data: {record_count} records")
                    break
                else:
                    print(f"    Warning: Error getting record {record_count + 1}, code: {result}")
                    break

            # Create record (same format as Log.txt)
            record = {
                "RecordNo": str(record_count + 1),
                "UserId": str(enroll_number.value),
                "VerifyMode": get_verify_mode_string(verify_mode.value),
                "InOutMode": get_inout_mode_string(inout_mode.value),
                "LogTime": convert_datetime_to_string(date_time.value)
            }

            records.append(record)
            record_count += 1

            if record_count % 10 == 0:
                print(f"    Processed {record_count} records...")

        print(f"✓ Disconnected from device")
        print(f"✓ Device extraction completed: {len(records)} records")

        # Step 4: Create JSON result
        json_result = {
            "Success": True,
            "Message": f"Successfully extracted {len(records)} attendance records for date range",
            "TotalRecords": len(records),
            "Records": records,
            "ExtractionTime": datetime.now().strftime("%Y-%m-%dT%H:%M:%S.%f"),
            "Source": "Date Range Python Extractor",
            "DeviceIP": DEVICE_IP,
            "DevicePort": DEVICE_PORT,
            "Method": "Numeric ID (Python)",
            "DateRange": {
                "StartDate": start_date_str,
                "EndDate": end_date_str
            },
            "Process": "Automated: Open Comm → Log Management → Read Log by Date Range"
        }

        # Output JSON
        json_output = json.dumps(json_result, indent=2, ensure_ascii=False)
        print("=== JSON OUTPUT (DATE RANGE EXTRACTOR) ===")
        print(json_output)

        # Save to file
        output_file = "attendance_data_date_range.json"
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(json_output)
        print(f"\n✅ Data saved to: {output_file}")

        # Summary
        print("\n=== SUMMARY ===")
        print(f"✅ SUCCESS: {len(records)} records extracted for date range")
        print(f"✅ Date Range: {start_date_str} to {end_date_str}")
        print(f"✅ Method: Numeric ID (avoids string buffer issues)")
        print(f"✅ Device: {json_result['DeviceIP']}:{json_result['DevicePort']}")
        print(f"✅ Process: Automated sample app workflow with date range")
        print(f"✅ Pure Python solution - no dotnet/msbuild needed!")

    finally:
        # Always disconnect
        fk_dll.FK_DisConnect(handle)

if __name__ == "__main__":
    main()
    print("\nPress Enter to exit...")
    input()

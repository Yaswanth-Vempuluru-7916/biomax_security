import ctypes
import ctypes.wintypes
import json
import os
import sys
from datetime import datetime

# Load the DLL
try:
    # Copy DLLs to current directory first
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

# String ID support constants
USER_ID_LENGTH = 16
USER_ID_LENGTH13_1 = 13

# Verify mode constants
class enumGLogVerifyMode:
    LOG_FPVERIFY = 0
    LOG_PASSVERIFY = 1
    LOG_CARDVERIFY = 2
    LOG_FACEVERIFY = 3

# In/Out mode constants
class enumGLogIOMode:
    LOG_IOMODE_IN1 = 0
    LOG_IOMODE_OUT1 = 1
    LOG_IOMODE_IN2 = 2
    LOG_IOMODE_OUT2 = 3
    LOG_IOMODE_IN3 = 4
    LOG_IOMODE_OUT3 = 5

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
    print("=== SAMPLE APP REPLICATOR ===")
    print("Replicates exact same process as sample application")
    print(f"Device: {DEVICE_IP}:{DEVICE_PORT}")
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

    fk_dll.FK_LoadGeneralLogData.argtypes = [
        ctypes.c_int,      # Handle
        ctypes.c_int       # ReadMark
    ]
    fk_dll.FK_LoadGeneralLogData.restype = ctypes.c_int

    fk_dll.FK_GetIsSupportStringID.argtypes = [ctypes.c_int]
    fk_dll.FK_GetIsSupportStringID.restype = ctypes.c_int

    fk_dll.FK_GetGeneralLogData.argtypes = [
        ctypes.c_int,                          # Handle
        ctypes.POINTER(ctypes.c_uint32),       # EnrollNumber
        ctypes.POINTER(ctypes.c_int),          # VerifyMode
        ctypes.POINTER(ctypes.c_int),          # InOutMode
        ctypes.POINTER(ctypes.c_uint32)        # DateTime
    ]
    fk_dll.FK_GetGeneralLogData.restype = ctypes.c_int

    fk_dll.FK_GetGeneralLogData_StringID_Workcode.argtypes = [
        ctypes.c_int,                          # Handle
        ctypes.c_char_p,                       # EnrollNumber (string buffer)
        ctypes.POINTER(ctypes.c_int),          # VerifyMode
        ctypes.POINTER(ctypes.c_int),          # InOutMode
        ctypes.POINTER(ctypes.c_uint32),       # DateTime
        ctypes.POINTER(ctypes.c_int)           # WorkCode
    ]
    fk_dll.FK_GetGeneralLogData_StringID_Workcode.restype = ctypes.c_int

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
        # Step 2: Load attendance data (same as "Read Log by Date" button)
        print("Step 2: Loading attendance data (Read Log by Date)...")
        
        # Use same parameters as sample app
        read_mark = 0  # 0 = read all data (same as sample app)
        result = fk_dll.FK_LoadGeneralLogData(handle, read_mark)

        if result != enumErrorCode.RUN_SUCCESS:
            print(f"✗ Failed to load data. Error code: {result}")
            return

        print("✓ Data loaded successfully from device")

        # Step 3: Check device capabilities (same logic as sample app)
        print("Step 3: Checking device capabilities...")
        string_id_support = fk_dll.FK_GetIsSupportStringID(handle)
        print(f"  String ID support: {string_id_support}")

        # Step 4: Extract data (same logic as sample app)
        print("Step 4: Extracting attendance records...")
        records = []
        record_count = 0

        if string_id_support >= enumErrorCode.RUN_SUCCESS:
            # Use String ID method (same as sample app)
            print("  Using String ID extraction method...")
            
            # Determine string length (same logic as sample app)
            if string_id_support == USER_ID_LENGTH13_1:
                string_length = USER_ID_LENGTH13_1
            else:
                string_length = USER_ID_LENGTH
            
            print(f"    Using string length: {string_length}")

            while True:
                # Create string buffer filled with spaces (EXACTLY like sample app)
                enroll_number_buffer = ctypes.create_string_buffer(b' ' * string_length)
                verify_mode = ctypes.c_int(0)
                inout_mode = ctypes.c_int(0)
                date_time = ctypes.c_uint32(0)
                work_code = ctypes.c_int(0)

                # Call the same function as sample app
                result = fk_dll.FK_GetGeneralLogData_StringID_Workcode(
                    handle,
                    enroll_number_buffer,
                    ctypes.byref(verify_mode),
                    ctypes.byref(inout_mode),
                    ctypes.byref(date_time),
                    ctypes.byref(work_code)
                )

                if result != enumErrorCode.RUN_SUCCESS:
                    if result == enumErrorCode.RUNERR_DATAARRAY_END:
                        print(f"    ✓ Reached end of string data: {record_count} records")
                        break
                    else:
                        print(f"    Warning: Error getting record {record_count + 1}, code: {result}")
                        break

                # Create record (same format as Log.txt)
                record = {
                    "RecordNo": str(record_count + 1),
                    "UserId": enroll_number_buffer.value.decode('ascii').strip(),
                    "VerifyMode": get_verify_mode_string(verify_mode.value),
                    "InOutMode": get_inout_mode_string(inout_mode.value),
                    "LogTime": convert_datetime_to_string(date_time.value),
                    "WorkCode": work_code.value
                }

                records.append(record)
                record_count += 1

                if record_count % 10 == 0:
                    print(f"    Processed {record_count} string records...")

        else:
            # Use Numeric ID method (same as sample app)
            print("  Using Numeric ID extraction method...")

            while True:
                enroll_number = ctypes.c_uint32(0)
                verify_mode = ctypes.c_int(0)
                inout_mode = ctypes.c_int(0)
                date_time = ctypes.c_uint32(0)

                # Call the same function as sample app
                result = fk_dll.FK_GetGeneralLogData(
                    handle,
                    ctypes.byref(enroll_number),
                    ctypes.byref(verify_mode),
                    ctypes.byref(inout_mode),
                    ctypes.byref(date_time)
                )

                if result != enumErrorCode.RUN_SUCCESS:
                    if result == enumErrorCode.RUNERR_DATAARRAY_END:
                        print(f"    ✓ Reached end of numeric data: {record_count} records")
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
                    print(f"    Processed {record_count} numeric records...")

        print(f"✓ Disconnected from device")
        print(f"✓ Device extraction completed: {len(records)} records")

        # Step 5: Create JSON result (same format as Log.txt but in JSON)
        json_result = {
            "Success": True,
            "Message": f"Successfully extracted {len(records)} attendance records (same as sample app)",
            "TotalRecords": len(records),
            "Records": records,
            "ExtractionTime": datetime.now().strftime("%Y-%m-%dT%H:%M:%S.%f"),
            "Source": "Sample App Replicator (Python)",
            "DeviceIP": DEVICE_IP,
            "DevicePort": DEVICE_PORT,
            "Method": "String ID" if string_id_support >= enumErrorCode.RUN_SUCCESS else "Numeric ID",
            "Process": "Automated: Open Comm → Log Management → Read Log by Date"
        }

        # Output JSON
        json_output = json.dumps(json_result, indent=2, ensure_ascii=False)
        print("=== JSON OUTPUT (SAMPLE APP REPLICATOR) ===")
        print(json_output)

        # Save to file
        output_file = "attendance_data_sample_app_replicator.json"
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(json_output)
        print(f"\n✅ Data saved to: {output_file}")

        # Summary
        print("\n=== SUMMARY ===")
        print(f"✅ SUCCESS: {len(records)} records extracted (same as sample app)")
        print(f"✅ Method: {json_result['Method']}")
        print(f"✅ Device: {json_result['DeviceIP']}:{json_result['DevicePort']}")
        print(f"✅ Process: Automated sample app workflow")

    finally:
        # Always disconnect
        fk_dll.FK_DisConnect(handle)

if __name__ == "__main__":
    main()
    print("\nPress Enter to exit...")
    input()

#!/usr/bin/env python3
"""
Pure Device Attendance Data Extractor
Extracts data DIRECTLY from the device only
"""

import ctypes
import ctypes.wintypes
import datetime
import json
import os
import sys
from ctypes import *

# Load Windows API for DLL directory setting
kernel32 = ctypes.windll.kernel32

# Device connection parameters
DEVICE_IP = "10.67.20.120"
DEVICE_PORT = 5005
MACHINE_NUMBER = 1
TIMEOUT = 5000
PROTOCOL_TCPIP = 0
PASSWORD = 0
LICENSE = 1261

# SDK Constants
USER_ID_LENGTH = 16
USER_ID_LENGTH13_1 = 32
RUN_SUCCESS = 1
RUNERR_INVALID_PARAM = -5
RUNERR_DATAARRAY_END = -7

def load_dll():
    """Load FK623Attend.dll with proper error handling"""
    try:
        kernel32.SetDllDirectoryW(os.path.abspath("."))
        dll_path = os.path.abspath("FK623Attend.dll")
        print(f"Loading DLL from: {dll_path}")
        
        dll = ctypes.CDLL(dll_path)
        print("✓ FK623Attend.dll loaded successfully")
        return dll
    except Exception as e:
        print(f"✗ Failed to load DLL: {e}")
        return None

def setup_function_signatures(dll):
    """Setup function signatures exactly as in the SDK"""
    
    # FK_ConnectNet - 7 parameters
    dll.FK_ConnectNet.argtypes = [
        ctypes.c_int,      # anMachineNo
        ctypes.c_char_p,   # astrIpAddress
        ctypes.c_int,      # anNetPort
        ctypes.c_int,      # anTimeOut
        ctypes.c_int,      # anProtocolType
        ctypes.c_int,      # anNetPassword
        ctypes.c_int       # anLicense
    ]
    dll.FK_ConnectNet.restype = ctypes.c_int
    
    # FK_DisConnect
    dll.FK_DisConnect.argtypes = [ctypes.c_int]
    dll.FK_DisConnect.restype = None
    
    # FK_GetLastError
    dll.FK_GetLastError.argtypes = [ctypes.c_int]
    dll.FK_GetLastError.restype = ctypes.c_int
    
    # FK_LoadGeneralLogData
    dll.FK_LoadGeneralLogData.argtypes = [ctypes.c_int, ctypes.c_int]
    dll.FK_LoadGeneralLogData.restype = ctypes.c_int
    
    # FK_GetIsSupportStringID
    dll.FK_GetIsSupportStringID.argtypes = [ctypes.c_int]
    dll.FK_GetIsSupportStringID.restype = ctypes.c_int
    
    # FK_GetGeneralLogData (numeric ID)
    dll.FK_GetGeneralLogData.argtypes = [
        ctypes.c_int,      # anHandleIndex
        ctypes.POINTER(ctypes.c_uint32),  # apnEnrollNumber
        ctypes.POINTER(ctypes.c_int),     # apnVerifyMode
        ctypes.POINTER(ctypes.c_int),     # apnInOutMode
        ctypes.POINTER(ctypes.c_uint32)   # apnDateTime (as integer)
    ]
    dll.FK_GetGeneralLogData.restype = ctypes.c_int
    
    # FK_GetGeneralLogData_StringID_Workcode (string ID) - FIXED SIGNATURE
    # C#: [MarshalAs(UnmanagedType.LPStr)] ref string apnEnrollNumber, ref DateTime apnDateTime
    dll.FK_GetGeneralLogData_StringID_Workcode.argtypes = [
        ctypes.c_int,      # anHandleIndex
        ctypes.c_char_p,   # apnEnrollNumber (string buffer)
        ctypes.POINTER(ctypes.c_int),     # apnVerifyMode
        ctypes.POINTER(ctypes.c_int),     # apnInOutMode
        ctypes.POINTER(ctypes.c_uint32),  # apnDateTime (as integer - SDK format)
        ctypes.POINTER(ctypes.c_int)      # apnWorkCode
    ]
    dll.FK_GetGeneralLogData_StringID_Workcode.restype = ctypes.c_int

def convert_sdk_datetime(sdk_datetime: int) -> str:
    """Convert SDK datetime format to readable string"""
    try:
        dt_str = str(sdk_datetime)
        if len(dt_str) == 14:
            year = int(dt_str[0:4])
            month = int(dt_str[4:6])
            day = int(dt_str[6:8])
            hour = int(dt_str[8:10])
            minute = int(dt_str[10:12])
            second = int(dt_str[12:14])
            
            return f"{year}/{month:02d}/{day:02d} {hour:02d}:{minute:02d}:{second:02d}"
        else:
            return str(sdk_datetime)
    except:
        return str(sdk_datetime)

def extract_numeric_data(dll, handle):
    """Extract data using numeric ID function"""
    print("  Extracting with numeric ID function...")
    
    records = []
    record_count = 0
    
    enroll_number = ctypes.c_uint32()
    verify_mode = ctypes.c_int()
    in_out_mode = ctypes.c_int()
    date_time = ctypes.c_uint32()
    
    while True:
        result = dll.FK_GetGeneralLogData(
            handle,
            ctypes.byref(enroll_number),
            ctypes.byref(verify_mode),
            ctypes.byref(in_out_mode),
            ctypes.byref(date_time)
        )
        
        if result != RUN_SUCCESS:
            if result == RUNERR_DATAARRAY_END:
                print(f"    ✓ Reached end of numeric data: {record_count} records")
                break
            else:
                print(f"    Warning: Error getting record {record_count + 1}, code: {result}")
                break
        
        record = {
            "RecordNo": record_count + 1,
            "UserId": str(enroll_number.value),
            "VerifyMode": verify_mode.value,
            "InOutMode": in_out_mode.value,
            "LogTime": convert_sdk_datetime(date_time.value)
        }
        
        records.append(record)
        record_count += 1
        
        if record_count % 10 == 0:
            print(f"    Processed {record_count} numeric records...")
    
    return records

def extract_string_data(dll, handle):
    """Extract data using string ID function"""
    print("  Extracting with string ID function...")
    
    string_id_support = dll.FK_GetIsSupportStringID(handle)
    print(f"    String ID support: {string_id_support}")
    
    if string_id_support < RUN_SUCCESS:
        print("    Device doesn't support string IDs")
        return []
    
    # Determine string length
    if string_id_support == USER_ID_LENGTH13_1:
        string_length = USER_ID_LENGTH13_1
    else:
        string_length = USER_ID_LENGTH
    
    print(f"    Using string length: {string_length}")
    
    # Create writable buffer FILLED WITH SPACES (like C# code)
    # C#: vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);
    enroll_number_buffer = (ctypes.c_char * string_length)()
    # Fill with spaces (0x20 = space character)
    for i in range(string_length):
        enroll_number_buffer[i] = b' '[0]  # Space character
    
    verify_mode = ctypes.c_int()
    in_out_mode = ctypes.c_int()
    date_time = ctypes.c_uint32()
    work_code = ctypes.c_int()
    
    records = []
    record_count = 0
    
    try:
        while True:
            result = dll.FK_GetGeneralLogData_StringID_Workcode(
                handle,
                enroll_number_buffer,
                ctypes.byref(verify_mode),
                ctypes.byref(in_out_mode),
                ctypes.byref(date_time),
                ctypes.byref(work_code)
            )
            
            if result != RUN_SUCCESS:
                if result == RUNERR_DATAARRAY_END:
                    print(f"    ✓ Reached end of string data: {record_count} records")
                    break
                else:
                    print(f"    Warning: Error getting record {record_count + 1}, code: {result}")
                    break
            
            # Extract string from buffer
            enroll_number_str = enroll_number_buffer.raw.decode('ascii').strip('\x00')
            
            record = {
                "RecordNo": record_count + 1,
                "UserId": enroll_number_str,
                "VerifyMode": verify_mode.value,
                "InOutMode": in_out_mode.value,
                "LogTime": convert_sdk_datetime(date_time.value),
                "WorkCode": work_code.value
            }
            
            records.append(record)
            record_count += 1
            
            if record_count % 10 == 0:
                print(f"    Processed {record_count} string records...")
            
            # Clear buffer for next iteration - FILL WITH SPACES AGAIN
            for i in range(string_length):
                enroll_number_buffer[i] = b' '[0]  # Space character
    
    except Exception as e:
        print(f"    String extraction failed: {e}")
        return []
    
    return records

def extract_from_device():
    """Extract attendance data DIRECTLY from device"""
    print("=== PURE DEVICE ATTENDANCE DATA EXTRACTOR ===")
    print("Extracting data DIRECTLY from device only")
    print(f"Device: {DEVICE_IP}:{DEVICE_PORT}")
    print()
    
    # Load DLL
    dll = load_dll()
    if not dll:
        return {"Success": False, "Message": "Failed to load DLL"}
    
    # Setup function signatures
    setup_function_signatures(dll)
    
    # Step 1: Connect to device
    print("Step 1: Connecting to device...")
    print(f"  IP: {DEVICE_IP}")
    print(f"  Port: {DEVICE_PORT}")
    print(f"  Machine: {MACHINE_NUMBER}")
    print(f"  Timeout: {TIMEOUT}")
    print(f"  Protocol: TCP/IP")
    print(f"  Password: {PASSWORD}")
    print(f"  License: {LICENSE}")
    
    # Convert IP to bytes for CharSet.Ansi
    ip_bytes = DEVICE_IP.encode('ascii')
    
    handle = dll.FK_ConnectNet(
        MACHINE_NUMBER,
        ip_bytes,
        DEVICE_PORT,
        TIMEOUT,
        PROTOCOL_TCPIP,
        PASSWORD,
        LICENSE
    )
    
    if handle <= 0:
        error_code = dll.FK_GetLastError(handle)
        print(f"✗ Connection failed. Handle: {handle}, Error: {error_code}")
        return {"Success": False, "Message": f"Failed to connect. Error code: {error_code}"}
    
    print(f"✓ Connected successfully! Handle: {handle}")
    
    try:
        # Step 2: Load attendance data
        print("Step 2: Loading attendance data from device...")
        result = dll.FK_LoadGeneralLogData(handle, 0)  # 0 = read all data
        
        if result != RUN_SUCCESS:
            print(f"✗ Failed to load data. Error code: {result}")
            return {"Success": False, "Message": f"Failed to load data. Error code: {result}"}
        
        print("✓ Data loaded successfully from device")
        
        # Step 3: Check device capabilities and extract data
        print("Step 3: Checking device capabilities...")
        string_id_support = dll.FK_GetIsSupportStringID(handle)
        print(f"  String ID support: {string_id_support}")
        
        # Try both extraction methods
        print("Step 4: Extracting data from device...")
        
        numeric_records = extract_numeric_data(dll, handle)
        string_records = extract_string_data(dll, handle)
        
        # Use whichever method got more records
        if len(string_records) > len(numeric_records):
            records = string_records
            method = "String ID"
            print(f"✓ Using String ID method: {len(records)} records")
        else:
            records = numeric_records
            method = "Numeric ID"
            print(f"✓ Using Numeric ID method: {len(records)} records")
        
        print(f"✓ Disconnected from device")
        print(f"✓ Device extraction completed: {len(records)} records using {method}")
        
        return {
            "Success": True,
            "Message": f"Successfully extracted {len(records)} attendance records DIRECTLY from device using {method}",
            "TotalRecords": len(records),
            "Records": records,
            "ExtractionTime": datetime.datetime.now().isoformat(),
            "Source": f"Device ({method})",
            "DeviceIP": DEVICE_IP,
            "DevicePort": DEVICE_PORT
        }
        
    finally:
        # Always disconnect
        dll.FK_DisConnect(handle)

def main():
    """Main function"""
    try:
        result = extract_from_device()
        
        # Output JSON
        json_output = json.dumps(result, indent=2, default=str)
        print("=== JSON OUTPUT (DIRECT FROM DEVICE) ===")
        print(json_output)
        
        # Save to file
        output_file = 'attendance_data_from_device.json'
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(json_output)
        
        print(f"Data saved to: {output_file}")
        
        # Summary
        print()
        print("=== SUMMARY ===")
        if result["Success"]:
            print(f"✅ SUCCESS: {result['TotalRecords']} records extracted DIRECTLY from device")
            print(f"✅ Method: {result['Source']}")
            print(f"✅ Device: {result['DeviceIP']}:{result['DevicePort']}")
        else:
            print(f"❌ FAILED: {result['Message']}")
        
    except Exception as e:
        print(f"✗ Error: {e}")
        return {"Success": False, "Message": f"Error: {str(e)}"}
    
    print()
    print("Press Enter to exit...")
    input()

if __name__ == "__main__":
    main()

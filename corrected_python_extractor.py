#!/usr/bin/env python3
"""
Corrected Python Attendance Data Extractor
Handles both numeric and string ID devices like the sample app
"""

import ctypes
import json
import datetime
import os
from typing import Dict, Any

def load_dll_with_dependencies():
    """Load DLL with proper dependency handling"""
    try:
        # Set DLL directory to current directory
        kernel32 = ctypes.windll.kernel32
        current_dir = os.path.abspath(".")
        kernel32.SetDllDirectoryW(current_dir)
        
        # Try to load the DLL with full path
        dll_path = os.path.join(current_dir, "FK623Attend.dll")
        print(f"Loading DLL from: {dll_path}")
        
        if not os.path.exists(dll_path):
            print(f"✗ DLL file not found: {dll_path}")
            return None
            
        dll = ctypes.CDLL(dll_path)
        print("✓ FK623Attend.dll loaded successfully")
        return dll
        
    except Exception as e:
        print(f"✗ Failed to load DLL: {e}")
        return None

# Load the DLL
fk_dll = load_dll_with_dependencies()
if not fk_dll:
    print("Make sure all DLL files are copied from Execute&Dll folder")
    exit(1)

# Device configuration - EXACTLY as used in sample app
DEVICE_IP = "10.67.20.120"
DEVICE_PORT = 5005
MACHINE_NUMBER = 1
PASSWORD = 0
TIMEOUT = 5000
LICENSE = 1261

# Define function signatures - EXACTLY as in sample app
fk_dll.FK_ConnectNet.argtypes = [
    ctypes.c_int,      # anMachineNo
    ctypes.c_char_p,   # astrIpAddress (CharSet.Ansi)
    ctypes.c_int,      # anNetPort
    ctypes.c_int,      # anTimeOut
    ctypes.c_int,      # anProtocolType
    ctypes.c_int,      # anNetPassword
    ctypes.c_int       # anLicense
]
fk_dll.FK_ConnectNet.restype = ctypes.c_int

fk_dll.FK_DisConnect.argtypes = [ctypes.c_int]
fk_dll.FK_DisConnect.restype = None

fk_dll.FK_EnableDevice.argtypes = [ctypes.c_int, ctypes.c_byte]
fk_dll.FK_EnableDevice.restype = ctypes.c_int

fk_dll.FK_LoadGeneralLogData.argtypes = [ctypes.c_int, ctypes.c_int]
fk_dll.FK_LoadGeneralLogData.restype = ctypes.c_int

# Function to check if device supports string IDs
fk_dll.FK_GetIsSupportStringID.argtypes = [ctypes.c_int]
fk_dll.FK_GetIsSupportStringID.restype = ctypes.c_int

# Numeric ID function (original)
fk_dll.FK_GetGeneralLogData.argtypes = [
    ctypes.c_int,      # anHandleIndex
    ctypes.POINTER(ctypes.c_uint32),  # apnEnrollNumber
    ctypes.POINTER(ctypes.c_int),     # apnVerifyMode
    ctypes.POINTER(ctypes.c_int),     # apnInOutMode
    ctypes.POINTER(ctypes.c_int),     # apnDateTime
    ctypes.POINTER(ctypes.c_int)      # apnWorkCode
]
fk_dll.FK_GetGeneralLogData.restype = ctypes.c_int

# String ID function (for devices with string user IDs)
fk_dll.FK_GetGeneralLogData_StringID_Workcode.argtypes = [
    ctypes.c_int,      # anHandleIndex
    ctypes.c_char_p,   # apnEnrollNumber (string buffer)
    ctypes.POINTER(ctypes.c_int),     # apnVerifyMode
    ctypes.POINTER(ctypes.c_int),     # apnInOutMode
    ctypes.POINTER(ctypes.c_int),     # apnDateTime
    ctypes.POINTER(ctypes.c_int)      # apnWorkCode
]
fk_dll.FK_GetGeneralLogData_StringID_Workcode.restype = ctypes.c_int

def get_verify_mode_string(verify_mode: int) -> str:
    """Convert verify mode number to string"""
    modes = {
        1: "Fingerprint",
        2: "Password", 
        3: "Card",
        4: "Fingerprint+Password",
        5: "Card+Fingerprint",
        6: "Password+Fingerprint",
        7: "Card+Fingerprint",
        8: "Job Number",
        9: "Card+Password",
        20: "Face",
        21: "Face+Card",
        22: "Face+Password",
        23: "Card+Face",
        24: "Password+Face"
    }
    return modes.get(verify_mode, "Unknown")

def get_inout_mode_string(inout_mode: int) -> str:
    """Convert in/out mode number to string"""
    modes = {
        0: "Check In",
        1: "Check Out",
        2: "Break Out",
        3: "Break In",
        4: "Overtime In",
        5: "Overtime Out"
    }
    return modes.get(inout_mode, "Unknown")

def convert_sdk_datetime(sdk_datetime: int) -> str:
    """Convert SDK datetime format to readable string"""
    try:
        # SDK datetime format: YYYYMMDDHHMMSS
        dt_str = str(sdk_datetime)
        if len(dt_str) == 14:
            year = int(dt_str[0:4])
            month = int(dt_str[4:6])
            day = int(dt_str[6:8])
            hour = int(dt_str[8:10])
            minute = int(dt_str[10:12])
            second = int(dt_str[12:14])
            
            dt = datetime.datetime(year, month, day, hour, minute, second)
            return dt.isoformat()
        else:
            return str(sdk_datetime)
    except:
        return str(sdk_datetime)

def extract_attendance_data() -> Dict[str, Any]:
    """Extract attendance data from the device"""
    result = {
        "Success": False,
        "Message": "",
        "TotalRecords": 0,
        "Records": [],
        "ExtractionTime": datetime.datetime.now().isoformat()
    }
    
    try:
        print("Step 1: Connecting to device...")
        print(f"  IP: {DEVICE_IP}")
        print(f"  Port: {DEVICE_PORT}")
        print(f"  Machine: {MACHINE_NUMBER}")
        print(f"  Timeout: {TIMEOUT}")
        print(f"  Protocol: TCP/IP")
        print(f"  Password: {PASSWORD}")
        print(f"  License: {LICENSE}")
        
        # Connect using EXACTLY the same parameters as sample app
        handle = fk_dll.FK_ConnectNet(
            MACHINE_NUMBER,
            DEVICE_IP.encode('ascii'),  # CharSet.Ansi equivalent
            DEVICE_PORT,
            TIMEOUT,
            0,  # PROTOCOL_TCPIP
            PASSWORD,
            LICENSE
        )
        
        if handle <= 0:
            result["Message"] = f"Failed to connect. Error code: {handle}"
            print(f"❌ Connection failed: {handle}")
            return result
        
        print(f"✓ Connected successfully! Handle: {handle}")
        
        print("Step 2: Loading attendance data...")
        load_result = fk_dll.FK_LoadGeneralLogData(handle, 0)  # 0 = read all data
        
        if load_result != 1:  # RUN_SUCCESS = 1
            result["Message"] = f"Failed to load data. Error code: {load_result}"
            print(f"❌ Failed to load data: {load_result}")
            fk_dll.FK_DisConnect(handle)
            return result
        
        print("✓ Data loaded successfully")
        
        print("Step 3: Checking device capabilities...")
        # Check if device supports string IDs (like sample app does)
        string_id_support = fk_dll.FK_GetIsSupportStringID(handle)
        print(f"  String ID support: {string_id_support}")
        
        if string_id_support >= 1:  # RUN_SUCCESS or higher
            print("  Using String ID function")
            use_string_id = True
        else:
            print("  Using Numeric ID function")
            use_string_id = False
        
        print("Step 4: Extracting attendance records...")
        record_count = 0
        
        if use_string_id:
            # String ID approach (like sample app)
            enroll_number = ctypes.create_string_buffer(24)  # Buffer for string ID
            verify_mode = ctypes.c_int(0)
            inout_mode = ctypes.c_int(0)
            sdk_datetime = ctypes.c_int(0)
            work_code = ctypes.c_int(0)
            
            while True:
                # Get next record using string ID function
                get_result = fk_dll.FK_GetGeneralLogData_StringID_Workcode(
                    handle,
                    enroll_number,
                    ctypes.byref(verify_mode),
                    ctypes.byref(inout_mode),
                    ctypes.byref(sdk_datetime),
                    ctypes.byref(work_code)
                )
                
                if get_result == 1:  # RUN_SUCCESS
                    # Convert data to record
                    user_id = enroll_number.value.decode('ascii').strip()
                    record = {
                        "UserId": user_id,
                        "LogTime": convert_sdk_datetime(sdk_datetime.value),
                        "VerifyMode": get_verify_mode_string(verify_mode.value),
                        "InOutMode": get_inout_mode_string(inout_mode.value),
                        "WorkCode": str(work_code.value)
                    }
                    
                    result["Records"].append(record)
                    record_count += 1
                    
                    if record_count % 10 == 0:
                        print(f"  Extracted {record_count} records...")
                        
                elif get_result == 0:  # RUNERR_DATAARRAY_END - no more data
                    break
                else:
                    print(f"Warning: Error getting record {record_count + 1}, code: {get_result}")
                    break
        else:
            # Numeric ID approach (like sample app)
            enroll_number = ctypes.c_uint32(0)
            verify_mode = ctypes.c_int(0)
            inout_mode = ctypes.c_int(0)
            sdk_datetime = ctypes.c_int(0)
            work_code = ctypes.c_int(0)
            
            while True:
                # Get next record using numeric ID function
                get_result = fk_dll.FK_GetGeneralLogData(
                    handle,
                    ctypes.byref(enroll_number),
                    ctypes.byref(verify_mode),
                    ctypes.byref(inout_mode),
                    ctypes.byref(sdk_datetime),
                    ctypes.byref(work_code)
                )
                
                if get_result == 1:  # RUN_SUCCESS
                    # Convert data to record
                    record = {
                        "UserId": str(enroll_number.value),
                        "LogTime": convert_sdk_datetime(sdk_datetime.value),
                        "VerifyMode": get_verify_mode_string(verify_mode.value),
                        "InOutMode": get_inout_mode_string(inout_mode.value),
                        "WorkCode": str(work_code.value)
                    }
                    
                    result["Records"].append(record)
                    record_count += 1
                    
                    if record_count % 10 == 0:
                        print(f"  Extracted {record_count} records...")
                        
                elif get_result == 0:  # RUNERR_DATAARRAY_END - no more data
                    break
                else:
                    print(f"Warning: Error getting record {record_count + 1}, code: {get_result}")
                    break
        
        # Disconnect
        fk_dll.FK_DisConnect(handle)
        print(f"✓ Disconnected from device")
        
        # Set success
        result["Success"] = True
        result["TotalRecords"] = record_count
        result["Message"] = f"Successfully extracted {record_count} attendance records"
        
        print(f"✓ Extraction completed: {record_count} records")
        
    except Exception as e:
        result["Message"] = f"Error during extraction: {str(e)}"
        print(f"✗ Error: {e}")
    
    return result

def main():
    """Main function"""
    print("=== Corrected Python Attendance Data Extractor ===")
    print("Handles both numeric and string ID devices")
    print(f"Connecting to device: {DEVICE_IP}:{DEVICE_PORT}")
    print()
    
    # Extract data
    result = extract_attendance_data()
    
    # Output JSON
    json_output = json.dumps(result, indent=2, default=str)
    print("=== JSON OUTPUT ===")
    print(json_output)
    
    # Save to file
    output_file = 'attendance_data.json'
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write(json_output)
    
    print()
    print(f"Data also saved to: {output_file}")
    print()
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()

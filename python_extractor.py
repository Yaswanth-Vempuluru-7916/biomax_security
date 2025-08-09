#!/usr/bin/env python3
"""
Python Attendance Data Extractor
Uses ctypes to call the FK623Attend.dll directly
"""

import ctypes
import json
import datetime
from typing import List, Dict, Any

# Load the DLL
try:
    # Try to load the DLL with full path
    import os
    current_dir = os.path.dirname(os.path.abspath(__file__))
    dll_path = os.path.join(current_dir, "FK623Attend.dll")
    
    if os.path.exists(dll_path):
        fk_dll = ctypes.CDLL(dll_path)
        print("✓ FK623Attend.dll loaded successfully")
    else:
        # Try loading from current directory
        fk_dll = ctypes.CDLL("FK623Attend.dll")
        print("✓ FK623Attend.dll loaded successfully")
except Exception as e:
    print(f"✗ Failed to load FK623Attend.dll: {e}")
    print("Make sure FK623Attend.dll and all its dependencies are in the same directory as this script")
    print("The script should have copied all required DLLs from Execute&Dll folder")
    exit(1)

# Device configuration
DEVICE_IP = "10.67.20.120"
DEVICE_PORT = 5005
MACHINE_NUMBER = 1
PASSWORD = 0
TIMEOUT = 5000
LICENSE = 1261

# Define function signatures
fk_dll.FK_ConnectNet.argtypes = [
    ctypes.c_int,      # anMachineNo
    ctypes.c_char_p,   # astrIpAddress
    ctypes.c_int,      # anNetPort
    ctypes.c_int,      # anTimeOut
    ctypes.c_int,      # anProtocolType
    ctypes.c_int,      # anNetPassword
    ctypes.c_int       # anLicense
]
fk_dll.FK_ConnectNet.restype = ctypes.c_int

fk_dll.FK_DisConnect.argtypes = [ctypes.c_int]
fk_dll.FK_DisConnect.restype = None

fk_dll.FK_LoadGeneralLogData.argtypes = [ctypes.c_int, ctypes.c_int]
fk_dll.FK_LoadGeneralLogData.restype = ctypes.c_int

fk_dll.FK_GetGeneralLogData.argtypes = [
    ctypes.c_int,      # anHandleIndex
    ctypes.POINTER(ctypes.c_uint32),  # apnEnrollNumber
    ctypes.POINTER(ctypes.c_int),     # apnVerifyMode
    ctypes.POINTER(ctypes.c_int),     # apnInOutMode
    ctypes.POINTER(ctypes.c_int),     # apnDateTime (we'll handle this specially)
    ctypes.POINTER(ctypes.c_int)      # apnWorkCode
]
fk_dll.FK_GetGeneralLogData.restype = ctypes.c_int

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
        1: "Check Out"
    }
    return modes.get(inout_mode, "Unknown")

def convert_sdk_datetime(sdk_datetime: int) -> datetime.datetime:
    """Convert SDK datetime format to Python datetime"""
    # SDK datetime format: YYYYMMDDHHMMSS
    if sdk_datetime == 0:
        return datetime.datetime.now()
    
    date_str = str(sdk_datetime)
    if len(date_str) != 14:
        return datetime.datetime.now()
    
    try:
        year = int(date_str[0:4])
        month = int(date_str[4:6])
        day = int(date_str[6:8])
        hour = int(date_str[8:10])
        minute = int(date_str[10:12])
        second = int(date_str[12:14])
        
        return datetime.datetime(year, month, day, hour, minute, second)
    except:
        return datetime.datetime.now()

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
        handle = fk_dll.FK_ConnectNet(
            MACHINE_NUMBER,
            DEVICE_IP.encode('ascii'),
            DEVICE_PORT,
            TIMEOUT,
            1,  # PROTOCOL_TCPIP
            PASSWORD,
            LICENSE
        )
        
        if handle <= 0:
            result["Message"] = f"Failed to connect. Error code: {handle}"
            return result
        
        print(f"✓ Connected successfully! Handle: {handle}")
        
        print("Step 2: Loading attendance data...")
        load_result = fk_dll.FK_LoadGeneralLogData(handle, 0)  # 0 = read all data
        
        if load_result != 1:  # RUN_SUCCESS = 1
            result["Message"] = f"Failed to load data. Error code: {load_result}"
            fk_dll.FK_DisConnect(handle)
            return result
        
        print("✓ Data loaded successfully")
        
        print("Step 3: Extracting attendance records...")
        record_count = 0
        
        # Variables for data extraction
        enroll_number = ctypes.c_uint32(0)
        verify_mode = ctypes.c_int(0)
        inout_mode = ctypes.c_int(0)
        sdk_datetime = ctypes.c_int(0)
        work_code = ctypes.c_int(0)
        
        while True:
            get_result = fk_dll.FK_GetGeneralLogData(
                handle,
                ctypes.byref(enroll_number),
                ctypes.byref(verify_mode),
                ctypes.byref(inout_mode),
                ctypes.byref(sdk_datetime),
                ctypes.byref(work_code)
            )
            
            if get_result != 1:  # RUN_SUCCESS = 1
                break
            
            # Convert SDK datetime to Python datetime
            log_time = convert_sdk_datetime(sdk_datetime.value)
            
            record = {
                "UserId": str(enroll_number.value),
                "VerifyMode": get_verify_mode_string(verify_mode.value),
                "InOutMode": get_inout_mode_string(inout_mode.value),
                "LogTime": log_time.isoformat(),
                "WorkCode": work_code.value
            }
            
            result["Records"].append(record)
            record_count += 1
        
        print(f"✓ Extraction completed! Found {record_count} records")
        
        # Disconnect
        fk_dll.FK_DisConnect(handle)
        
        # Success!
        result["Success"] = True
        result["TotalRecords"] = record_count
        result["Message"] = f"Successfully extracted {record_count} attendance records"
        
    except Exception as ex:
        result["Message"] = f"Error during extraction: {str(ex)}"
        print(f"✗ Error: {ex}")
    
    return result

def main():
    """Main function"""
    print("=== Python Attendance Data Extractor ===")
    print(f"Connecting to device: {DEVICE_IP}:{DEVICE_PORT}")
    print()
    
    result = extract_attendance_data()
    
    # Output JSON
    json_output = json.dumps(result, indent=2, default=str)
    print("=== JSON OUTPUT ===")
    print(json_output)
    
    # Save to file
    with open("attendance_data.json", "w") as f:
        f.write(json_output)
    
    print()
    print("Data also saved to: attendance_data.json")
    print()
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()

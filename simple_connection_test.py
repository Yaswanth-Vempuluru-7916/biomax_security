#!/usr/bin/env python3
"""
Simple Connection Test
Uses the same approach as the working simple_python_extractor.py
"""

import ctypes
import os
import time

def main():
    print("=== Simple Connection Test ===")
    print()
    
    # Device settings
    device_ip = "10.67.20.120"
    device_port = 5005
    machine_number = 1
    timeout = 5000
    protocol_type = 1  # PROTOCOL_TCPIP
    password = 0
    license = 1261
    
    print(f"Device IP: {device_ip}")
    print(f"Device Port: {device_port}")
    print(f"Machine Number: {machine_number}")
    print(f"Timeout: {timeout}")
    print(f"Protocol: {protocol_type}")
    print(f"Password: {password}")
    print(f"License: {license}")
    print()
    
    try:
        # Load DLL using the same method as simple_python_extractor.py
        print("Step 1: Loading DLL...")
        kernel32 = ctypes.windll.kernel32
        current_dir = os.path.abspath(".")
        kernel32.SetDllDirectoryW(current_dir)
        
        dll_path = os.path.join(current_dir, "FK623Attend.dll")
        dll = ctypes.CDLL(dll_path)
        print("✓ FK623Attend.dll loaded successfully")
        
        # Define function signature
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
        
        # Test connection with correct parameters
        print("\nStep 2: Testing connection...")
        result = dll.FK_ConnectNet(
            machine_number,
            device_ip.encode('ascii'),
            device_port,
            timeout,
            protocol_type,
            password,
            license
        )
        print(f"Connection result: {result}")
        
        if result > 0:
            print(f"🎉 SUCCESS: Device connected! Handle: {result}")
            
            # Test disconnection
            print("\nStep 3: Testing disconnection...")
            dll.FK_DisConnect(result)
            print("✓ Disconnected successfully")
            
        else:
            print(f"❌ Connection failed with code: {result}")
            
            # Try to get more information about the error
            print("\nTrying to get error information...")
            
            # Test with different parameters
            print("Retrying with 2 second delay...")
            time.sleep(2)
            result2 = dll.FK_ConnectNet(
                machine_number,
                device_ip.encode('ascii'),
                device_port,
                timeout,
                protocol_type,
                password,
                license
            )
            print(f"Retry result: {result2}")
            
            if result2 > 0:
                print(f"🎉 SUCCESS: Connection worked on retry! Handle: {result2}")
                dll.FK_DisConnect(result2)
            else:
                print(f"❌ Still failed: {result2}")
                
    except Exception as e:
        print(f"✗ Error: {e}")
    
    print("\nPress Enter to exit...")
    input()

if __name__ == "__main__":
    main()

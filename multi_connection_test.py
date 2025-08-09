#!/usr/bin/env python3
"""
Multi-Connection Test
Tries different connection parameters to find working settings
"""

import ctypes
import os
import time

def load_dll():
    """Load DLL with proper dependency handling"""
    try:
        kernel32 = ctypes.windll.kernel32
        current_dir = os.path.abspath(".")
        kernel32.SetDllDirectoryW(current_dir)
        
        dll_path = os.path.join(current_dir, "FK623Attend.dll")
        dll = ctypes.CDLL(dll_path)
        print("✓ FK623Attend.dll loaded successfully")
        return dll
    except Exception as e:
        print(f"✗ Failed to load DLL: {e}")
        return None

def test_connection(dll, machine_no, ip, port, timeout, protocol, password, license):
    """Test a specific connection configuration"""
    try:
        # Define function signature
        dll.FK_ConnectNet.argtypes = [
            ctypes.c_int, ctypes.c_char_p, ctypes.c_int, 
            ctypes.c_int, ctypes.c_int, ctypes.c_int, ctypes.c_int
        ]
        dll.FK_ConnectNet.restype = ctypes.c_int
        
        # Test connection
        result = dll.FK_ConnectNet(
            machine_no, ip.encode('ascii'), port, 
            timeout, protocol, password, license
        )
        
        if result > 0:
            print(f"🎉 SUCCESS! Handle: {result}")
            dll.FK_DisConnect(result)
            return True
        else:
            print(f"❌ Failed: {result}")
            return False
            
    except Exception as e:
        print(f"✗ Error: {e}")
        return False

def main():
    print("=== Multi-Connection Test ===")
    print("Testing different connection parameters...")
    print()
    
    # Load DLL
    dll = load_dll()
    if not dll:
        return
    
    # Test configurations
    configs = [
        # Standard configuration
        {
            "name": "Standard Config",
            "machine_no": 1,
            "ip": "10.67.20.120",
            "port": 5005,
            "timeout": 5000,
            "protocol": 1,
            "password": 0,
            "license": 1261
        },
        # Try different machine numbers
        {
            "name": "Machine Number 0",
            "machine_no": 0,
            "ip": "10.67.20.120",
            "port": 5005,
            "timeout": 5000,
            "protocol": 1,
            "password": 0,
            "license": 1261
        },
        # Try different timeout
        {
            "name": "Longer Timeout (10s)",
            "machine_no": 1,
            "ip": "10.67.20.120",
            "port": 5005,
            "timeout": 10000,
            "protocol": 1,
            "password": 0,
            "license": 1261
        },
        # Try different port
        {
            "name": "Port 4370 (Common)",
            "machine_no": 1,
            "ip": "10.67.20.120",
            "port": 4370,
            "timeout": 5000,
            "protocol": 1,
            "password": 0,
            "license": 1261
        },
        # Try different protocol
        {
            "name": "UDP Protocol",
            "machine_no": 1,
            "ip": "10.67.20.120",
            "port": 5005,
            "timeout": 5000,
            "protocol": 0,  # UDP
            "password": 0,
            "license": 1261
        },
        # Try different license
        {
            "name": "License 0",
            "machine_no": 1,
            "ip": "10.67.20.120",
            "port": 5005,
            "timeout": 5000,
            "protocol": 1,
            "password": 0,
            "license": 0
        }
    ]
    
    success_count = 0
    
    for i, config in enumerate(configs, 1):
        print(f"Test {i}: {config['name']}")
        print(f"  Machine: {config['machine_no']}, IP: {config['ip']}:{config['port']}")
        print(f"  Timeout: {config['timeout']}, Protocol: {config['protocol']}")
        print(f"  Password: {config['password']}, License: {config['license']}")
        
        if test_connection(
            dll, config['machine_no'], config['ip'], config['port'],
            config['timeout'], config['protocol'], config['password'], config['license']
        ):
            success_count += 1
            print(f"  ✅ {config['name']} WORKED!")
        else:
            print(f"  ❌ {config['name']} failed")
        
        print()
        time.sleep(1)  # Small delay between tests
    
    print("=== Test Summary ===")
    print(f"Total tests: {len(configs)}")
    print(f"Successful: {success_count}")
    print(f"Failed: {len(configs) - success_count}")
    
    if success_count > 0:
        print("🎉 Found working configuration!")
    else:
        print("❌ No working configuration found")
        print()
        print("Possible issues:")
        print("1. Device not powered on")
        print("2. Wrong IP address")
        print("3. Device not on network")
        print("4. Firewall blocking connection")
        print("5. Device requires different settings")
        print()
        print("Try the sample application to verify device connectivity")
    
    print("\nPress Enter to exit...")
    input()

if __name__ == "__main__":
    main()

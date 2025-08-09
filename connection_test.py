#!/usr/bin/env python3
"""
Connection Test Script
Tests network connectivity to the biometric device
"""

import socket
import time
import ctypes
import json
import datetime
import os

def test_network_connectivity(ip, port):
    """Test basic network connectivity"""
    print(f"=== Network Connectivity Test ===")
    print(f"Testing connection to {ip}:{port}")
    print()
    
    try:
        # Test 1: Basic socket connection
        print("Test 1: Basic socket connection...")
        sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        sock.settimeout(5)  # 5 second timeout
        
        result = sock.connect_ex((ip, port))
        if result == 0:
            print("✓ Socket connection successful")
            sock.close()
            return True
        else:
            print(f"✗ Socket connection failed: {result}")
            return False
            
    except Exception as e:
        print(f"✗ Socket test error: {e}")
        return False

def load_dll_robustly():
    """Load DLL with robust error handling"""
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

def test_device_connection(ip, port):
    """Test device connection using the SDK"""
    print(f"=== Device Connection Test ===")
    print(f"Testing device at {ip}:{port}")
    print()
    
    try:
        # Load the DLL with robust method
        dll = load_dll_robustly()
        if not dll:
            return False
        
        # Test connection with different parameters
        print("\nTesting connection parameters...")
        
        # Test 1: Basic connection
        print("Test 1: Basic connection...")
        result = dll.FK_ConnectNet(ip.encode('utf-8'), port)
        print(f"Connection result: {result}")
        
        if result == 1:
            print("✓ Connection successful!")
            dll.FK_Disconnect()
            return True
        else:
            print(f"✗ Connection failed with code: {result}")
            
            # Test 2: Try with different timeout
            print("\nTest 2: Connection with longer timeout...")
            time.sleep(2)
            result = dll.FK_ConnectNet(ip.encode('utf-8'), port)
            print(f"Connection result: {result}")
            
            if result == 1:
                print("✓ Connection successful on retry!")
                dll.FK_Disconnect()
                return True
            else:
                print(f"✗ Connection still failed: {result}")
                
        return False
        
    except Exception as e:
        print(f"✗ Device test error: {e}")
        return False

def suggest_solutions():
    """Suggest solutions based on the test results"""
    print("\n=== Troubleshooting Suggestions ===")
    print()
    
    print("1. Check Device Status:")
    print("   - Ensure the device is powered on")
    print("   - Check if the device is connected to the network")
    print("   - Verify the device shows the correct IP address")
    print()
    
    print("2. Check Network Configuration:")
    print("   - Verify IP address: 10.67.20.120")
    print("   - Verify port: 5005")
    print("   - Check if your computer is on the same network")
    print("   - Try pinging the device: ping 10.67.20.120")
    print()
    
    print("3. Check Firewall/Security:")
    print("   - Ensure Windows Firewall allows the connection")
    print("   - Check if any antivirus is blocking the connection")
    print("   - Try temporarily disabling firewall for testing")
    print()
    
    print("4. Alternative Connection Methods:")
    print("   - Try using the sample application first")
    print("   - Check if the device has a web interface")
    print("   - Verify the device manual for correct connection settings")
    print()

def main():
    """Main test function"""
    print("=== Biometric Device Connection Test ===")
    print()
    
    # Device settings
    device_ip = "10.67.20.120"
    device_port = 5005
    
    print(f"Device IP: {device_ip}")
    print(f"Device Port: {device_port}")
    print()
    
    # Test network connectivity
    network_ok = test_network_connectivity(device_ip, device_port)
    
    if network_ok:
        print("\n✓ Network connectivity is working")
        print("Testing device connection...")
        device_ok = test_device_connection(device_ip, device_port)
        
        if device_ok:
            print("\n🎉 SUCCESS: Device connection working!")
        else:
            print("\n❌ Device connection failed")
            suggest_solutions()
    else:
        print("\n❌ Network connectivity failed")
        suggest_solutions()
    
    print("\nPress Enter to exit...")
    input()

if __name__ == "__main__":
    main()

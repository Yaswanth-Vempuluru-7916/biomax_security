#!/usr/bin/env python3
"""
DLL Diagnostic Script
Helps identify and fix DLL loading issues
"""

import os
import sys
import platform
import ctypes
from ctypes import wintypes

def check_system_info():
    """Check system architecture and Python version"""
    print("=== System Information ===")
    print(f"Python Version: {sys.version}")
    print(f"Platform: {platform.platform()}")
    print(f"Architecture: {platform.architecture()}")
    print(f"Machine: {platform.machine()}")
    print(f"Processor: {platform.processor()}")
    print()

def check_dll_files():
    """Check if all required DLL files exist"""
    print("=== DLL File Check ===")
    required_files = [
        "FK623Attend.dll",
        "FKAttend.dll", 
        "FKViaDev.dll",
        "FaceDataConv.dll",
        "FpDataConv.dll",
        "FKPwdEncDec.dll",
        "LFWViaDev.dll",
        "adodb.dll"
    ]
    
    missing_files = []
    for file in required_files:
        if os.path.exists(file):
            size = os.path.getsize(file)
            print(f"✓ {file} - {size:,} bytes")
        else:
            print(f"✗ {file} - MISSING")
            missing_files.append(file)
    
    print()
    return missing_files

def try_load_dll_different_ways():
    """Try different methods to load the DLL"""
    print("=== DLL Loading Tests ===")
    
    dll_path = "FK623Attend.dll"
    if not os.path.exists(dll_path):
        print(f"✗ {dll_path} not found")
        return False
    
    # Method 1: Direct load
    try:
        print("Method 1: Direct CDLL load...")
        dll = ctypes.CDLL(dll_path)
        print("✓ Success!")
        return True
    except Exception as e:
        print(f"✗ Failed: {e}")
    
    # Method 2: LoadLibrary
    try:
        print("Method 2: LoadLibrary...")
        kernel32 = ctypes.windll.kernel32
        handle = kernel32.LoadLibraryW(dll_path)
        if handle:
            print("✓ Success!")
            return True
        else:
            print("✗ Failed: LoadLibrary returned 0")
    except Exception as e:
        print(f"✗ Failed: {e}")
    
    # Method 3: Set DLL directory first
    try:
        print("Method 3: Set DLL directory...")
        kernel32 = ctypes.windll.kernel32
        current_dir = os.path.abspath(".")
        kernel32.SetDllDirectoryW(current_dir)
        dll = ctypes.CDLL(dll_path)
        print("✓ Success!")
        return True
    except Exception as e:
        print(f"✗ Failed: {e}")
    
    return False

def check_dll_dependencies():
    """Check DLL dependencies using Dependency Walker approach"""
    print("=== DLL Dependency Check ===")
    
    try:
        # Try to load with verbose error checking
        kernel32 = ctypes.windll.kernel32
        
        # Get error mode
        SEM_FAILCRITICALERRORS = 0x0001
        SEM_NOGPFAULTERRORBOX = 0x0002
        SEM_NOALIGNMENTFAULTEXCEPT = 0x0004
        SEM_NOOPENFILEERRORBOX = 0x8000
        
        old_mode = kernel32.SetErrorMode(SEM_FAILCRITICALERRORS | SEM_NOGPFAULTERRORBOX)
        
        try:
            dll = ctypes.CDLL("FK623Attend.dll")
            print("✓ DLL loaded successfully with error suppression")
            return True
        except Exception as e:
            print(f"✗ Still failed: {e}")
            return False
        finally:
            kernel32.SetErrorMode(old_mode)
            
    except Exception as e:
        print(f"✗ Error checking dependencies: {e}")
        return False

def suggest_solutions():
    """Suggest solutions based on the issues found"""
    print("=== Suggested Solutions ===")
    print()
    
    print("Solution 1: Use the existing sample application")
    print("- This is the most reliable approach")
    print("- Run: Execute&Dll\\FK623AttendDllCSSample.exe")
    print("- Enter IP: 10.67.20.120, Port: 5005")
    print("- Connect and export data manually")
    print()
    
    print("Solution 2: Try 32-bit Python")
    print("- The DLL might be 32-bit only")
    print("- Download 32-bit Python from: https://www.python.org/downloads/")
    print("- Install 32-bit Python and try again")
    print()
    
    print("Solution 3: Use Windows API directly")
    print("- Create a simple C++/C# wrapper")
    print("- Or use the existing C# sample as base")
    print()
    
    print("Solution 4: Check DLL architecture")
    print("- Use 'dumpbin /headers FK623Attend.dll' to check architecture")
    print("- Ensure DLL matches your Python architecture")
    print()

def main():
    """Main diagnostic function"""
    print("=== DLL Diagnostic Tool ===")
    print()
    
    check_system_info()
    missing_files = check_dll_files()
    
    if missing_files:
        print(f"Missing {len(missing_files)} required files!")
        print("Please copy all DLL files from Execute&Dll folder")
        return
    
    print("All required files found. Testing DLL loading...")
    print()
    
    success = try_load_dll_different_ways()
    
    if not success:
        print("All loading methods failed. Checking dependencies...")
        print()
        check_dll_dependencies()
    
    print()
    suggest_solutions()
    
    print("Press Enter to exit...")
    input()

if __name__ == "__main__":
    main()

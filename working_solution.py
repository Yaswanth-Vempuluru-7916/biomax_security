#!/usr/bin/env python3
"""
Working Solution: Use Sample App + JSON Conversion
This is the most reliable approach since the sample app works perfectly
"""

import json
import datetime
import os
import subprocess
import time
from typing import Dict, Any

def check_log_file():
    """Check if Log.txt exists and has data"""
    log_file = "Execute&Dll\\Log.txt"
    if not os.path.exists(log_file):
        return None, "Log.txt not found"
    
    try:
        with open(log_file, 'r', encoding='utf-8', errors='ignore') as f:
            lines = f.readlines()
        
        if len(lines) < 2:
            return None, "Log.txt is empty or has no data rows"
        
        # Parse header
        header_line = lines[0].strip()
        headers = [h.strip() for h in header_line.split('\t')]
        
        # Parse data rows
        records = []
        for i, line in enumerate(lines[1:], 1):
            line = line.strip()
            if not line:
                continue
                
            values = line.split('\t')
            if len(values) >= 5:
                record = {
                    "RecordNo": values[0].strip(),
                    "UserId": values[1].strip(),
                    "VerifyMode": values[2].strip(),
                    "InOutMode": values[3].strip(),
                    "LogTime": values[4].strip()  # Keep original format: 2025/08/06 08:25:22
                }
                records.append(record)
        
        return records, f"Found {len(records)} records in Log.txt"
        
    except Exception as e:
        return None, f"Error reading Log.txt: {e}"

def run_sample_app_instructions():
    """Provide instructions for running the sample app"""
    print("=== WORKING SOLUTION INSTRUCTIONS ===")
    print()
    print("Since direct Python DLL calls have issues, here's the working approach:")
    print()
    print("1. Run the sample application:")
    print("   Execute&Dll\\FK623AttendDllCSSample.exe")
    print()
    print("2. In the sample app:")
    print("   - Enter IP: 10.67.20.120")
    print("   - Enter Port: 5005")
    print("   - Click 'Open Comm'")
    print("   - Go to 'Log Management' tab")
    print("   - Click 'Read Log by Date'")
    print("   - Select date range and click OK")
    print()
    print("3. The app will automatically save data to:")
    print("   Execute&Dll\\Log.txt")
    print()
    print("4. Then run this script again to convert to JSON")
    print()

def convert_log_to_json():
    """Convert Log.txt to JSON format"""
    print("=== WORKING SOLUTION: LOG.TXT TO JSON ===")
    print()
    
    # Check if Log.txt exists
    records, message = check_log_file()
    
    if records is None:
        print(f"❌ {message}")
        print()
        run_sample_app_instructions()
        return None
    
    print(f"✅ {message}")
    print()
    
    # Create result
    result = {
        "Success": True,
        "Message": f"Successfully converted {len(records)} records from Log.txt",
        "TotalRecords": len(records),
        "Records": records,
        "ExtractionTime": datetime.datetime.now().isoformat(),
        "Source": "Sample Application + Log.txt",
        "DeviceIP": "10.67.20.120",
        "DevicePort": 5005,
        "Method": "Sample App Extraction"
    }
    
    # Output JSON
    json_output = json.dumps(result, indent=2, default=str)
    print("=== JSON OUTPUT ===")
    print(json_output)
    
    # Save to file
    output_file = 'attendance_data_working.json'
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write(json_output)
    
    print(f"\n✅ Data saved to: {output_file}")
    
    # Show sample records
    if records:
        print(f"\n=== SAMPLE RECORDS ({min(3, len(records))} of {len(records)}) ===")
        for i, record in enumerate(records[:3]):
            print(f"Record {i+1}: {record}")
    
    return result

def main():
    """Main function"""
    print("=== WORKING ATTENDANCE DATA SOLUTION ===")
    print("Uses sample application + JSON conversion")
    print()
    
    # Try to convert existing Log.txt
    result = convert_log_to_json()
    
    if result is None:
        print("\n=== NEXT STEPS ===")
        print("1. Run the sample application to extract data")
        print("2. Run this script again to convert to JSON")
        print()
        print("This approach is 100% reliable since the sample app works perfectly!")
    
    print()
    print("Press Enter to exit...")
    input()

if __name__ == "__main__":
    main()

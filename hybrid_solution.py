#!/usr/bin/env python3
"""
Hybrid Solution: Use Sample App + Python Converter
Since the sample app works perfectly, let's use it to export data and convert to JSON
"""

import json
import datetime
import os
import subprocess
import time
from typing import Dict, Any

def check_sample_app():
    """Check if sample app exists"""
    sample_path = "Execute&Dll\\FK623AttendDllCSSample.exe"
    if os.path.exists(sample_path):
        print(f"✓ Sample app found: {sample_path}")
        return True
    else:
        print(f"✗ Sample app not found: {sample_path}")
        return False

def create_instructions():
    """Create instructions for manual export"""
    instructions = """
=== MANUAL EXPORT INSTRUCTIONS ===

Since the Python direct extraction is having issues, let's use the working sample app:

1. Run the sample application:
   Execute&Dll\\FK623AttendDllCSSample.exe

2. Configure connection:
   - Select "Network Device"
   - IP: 10.67.20.120
   - Port: 5005
   - Machine Number: 1
   - Password: 0
   - Timeout: 5000
   - License: 1261
   - Click "Open Comm"

3. Export attendance data:
   - Click "Log Management" (should be enabled after connection)
   - Click "Read Log by Date"
   - Select your desired date range
   - Click "Download" or "Export"
   - Save as "attendance.csv" in the current directory

4. Run this script again to convert to JSON:
   python hybrid_solution.py

The sample app works perfectly, so this will give you reliable JSON output!
"""
    print(instructions)
    
    # Create a batch file to launch the sample app
    with open("launch_sample_app.bat", "w") as f:
        f.write("@echo off\n")
        f.write("echo Launching sample application...\n")
        f.write("echo Please follow the instructions above.\n")
        f.write("echo.\n")
        f.write("start \"\" \"Execute&Dll\\FK623AttendDllCSSample.exe\"\n")
        f.write("echo Sample app launched!\n")
        f.write("pause\n")
    
    print("✓ Created launch_sample_app.bat")
    print("Run: launch_sample_app.bat")

def convert_csv_to_json(csv_file: str) -> Dict[str, Any]:
    """Convert CSV file to JSON format"""
    result = {
        "Success": False,
        "Message": "",
        "TotalRecords": 0,
        "Records": [],
        "ExtractionTime": datetime.datetime.now().isoformat(),
        "SourceFile": csv_file
    }
    
    try:
        if not os.path.exists(csv_file):
            result["Message"] = f"CSV file not found: {csv_file}"
            return result
        
        print(f"Converting {csv_file} to JSON...")
        
        # Read CSV file
        with open(csv_file, 'r', encoding='utf-8', errors='ignore') as f:
            lines = f.readlines()
        
        if len(lines) < 2:  # Need header + at least one data row
            result["Message"] = "CSV file is empty or has no data rows"
            return result
        
        # Parse header
        header_line = lines[0].strip()
        headers = [h.strip() for h in header_line.split(',')]
        
        print(f"Found headers: {headers}")
        
        # Parse data rows
        record_count = 0
        for i, line in enumerate(lines[1:], 1):
            line = line.strip()
            if not line:
                continue
                
            # Split by comma, handle quoted fields
            values = []
            current_value = ""
            in_quotes = False
            
            for char in line:
                if char == '"':
                    in_quotes = not in_quotes
                elif char == ',' and not in_quotes:
                    values.append(current_value.strip())
                    current_value = ""
                else:
                    current_value += char
            
            values.append(current_value.strip())
            
            # Create record
            if len(values) >= len(headers):
                record = {}
                for j, header in enumerate(headers):
                    if j < len(values):
                        record[header] = values[j]
                    else:
                        record[header] = ""
                
                result["Records"].append(record)
                record_count += 1
                
                if record_count % 10 == 0:
                    print(f"  Processed {record_count} records...")
        
        # Set success
        result["Success"] = True
        result["TotalRecords"] = record_count
        result["Message"] = f"Successfully converted {record_count} records from CSV"
        
        print(f"✓ Conversion completed: {record_count} records")
        
    except Exception as e:
        result["Message"] = f"Error converting CSV: {str(e)}"
        print(f"✗ Error: {e}")
    
    return result

def main():
    """Main function"""
    print("=== Hybrid Solution: Sample App + Python Converter ===")
    print("Using the working sample app to export data, then converting to JSON")
    print()
    
    # Check if sample app exists
    if not check_sample_app():
        print("Please make sure the sample app is available.")
        return
    
    # Check if CSV file exists
    csv_files = [
        "attendance.csv",
        "attendance_data.csv", 
        "log_data.csv",
        "export.csv"
    ]
    
    csv_found = None
    for csv_file in csv_files:
        if os.path.exists(csv_file):
            csv_found = csv_file
            break
    
    if csv_found:
        print(f"✓ Found CSV file: {csv_found}")
        print()
        
        # Convert to JSON
        result = convert_csv_to_json(csv_found)
        
        # Output JSON
        json_output = json.dumps(result, indent=2, default=str)
        print("=== JSON OUTPUT ===")
        print(json_output)
        
        # Save to file
        output_file = 'attendance_data.json'
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(json_output)
        
        print()
        print(f"Data saved to: {output_file}")
        
    else:
        print("No CSV file found. Creating instructions for manual export...")
        print()
        create_instructions()
    
    print()
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()

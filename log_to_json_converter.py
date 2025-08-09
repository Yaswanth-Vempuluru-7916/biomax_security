#!/usr/bin/env python3
"""
Log to JSON Converter
Reads the Log.txt file and converts it to JSON with the specified date format
"""

import json
import datetime
import os
from typing import Dict, Any

def convert_log_to_json(log_file: str) -> Dict[str, Any]:
    """Convert Log.txt file to JSON format"""
    result = {
        "Success": False,
        "Message": "",
        "TotalRecords": 0,
        "Records": [],
        "ExtractionTime": datetime.datetime.now().isoformat(),
        "SourceFile": log_file
    }
    
    try:
        if not os.path.exists(log_file):
            result["Message"] = f"Log file not found: {log_file}"
            return result
        
        print(f"Converting {log_file} to JSON...")
        
        # Read log file
        with open(log_file, 'r', encoding='utf-8', errors='ignore') as f:
            lines = f.readlines()
        
        if len(lines) < 2:  # Need header + at least one data row
            result["Message"] = "Log file is empty or has no data rows"
            return result
        
        # Parse header
        header_line = lines[0].strip()
        headers = [h.strip() for h in header_line.split('\t')]
        
        print(f"Found headers: {headers}")
        
        # Parse data rows
        record_count = 0
        for i, line in enumerate(lines[1:], 1):
            line = line.strip()
            if not line:
                continue
                
            # Split by tab
            values = line.split('\t')
            
            if len(values) >= 5:  # No., EnrNo, Verify, InOut, DateTime
                # Create record with proper field mapping
                record = {
                    "RecordNo": values[0].strip(),
                    "UserId": values[1].strip(),
                    "VerifyMode": values[2].strip(),
                    "InOutMode": values[3].strip(),
                    "LogTime": values[4].strip()  # Keep original format: 2025/08/06 08:25:22
                }
                
                # Add any additional fields if they exist
                if len(values) > 5:
                    record["AdditionalInfo"] = values[5].strip()
                
                result["Records"].append(record)
                record_count += 1
                
                if record_count % 10 == 0:
                    print(f"  Processed {record_count} records...")
        
        # Set success
        result["Success"] = True
        result["TotalRecords"] = record_count
        result["Message"] = f"Successfully converted {record_count} records from log file"
        
        print(f"✓ Conversion completed: {record_count} records")
        
    except Exception as e:
        result["Message"] = f"Error converting log file: {str(e)}"
        print(f"✗ Error: {e}")
    
    return result

def main():
    """Main function"""
    print("=== Log to JSON Converter ===")
    print("Converting Log.txt to JSON with date format: 2025/08/06 08:25:22")
    print()
    
    # Check for log file
    log_files = [
        "Execute&Dll\\Log.txt",
        "Log.txt",
        "attendance_log.txt"
    ]
    
    log_found = None
    for log_file in log_files:
        if os.path.exists(log_file):
            log_found = log_file
            break
    
    if log_found:
        print(f"✓ Found log file: {log_found}")
        print()
        
        # Convert to JSON
        result = convert_log_to_json(log_found)
        
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
        
        # Show sample record
        if result["Records"]:
            print()
            print("=== Sample Record ===")
            sample = result["Records"][0]
            print(json.dumps(sample, indent=2))
        
    else:
        print("No log file found. Looking for:")
        for log_file in log_files:
            print(f"  - {log_file}")
        print()
        print("Please make sure the Log.txt file is available.")
    
    print()
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()


#!/usr/bin/env python3
"""
CSV to JSON Converter
Converts attendance data from CSV (exported from sample app) to JSON format
"""

import csv
import json
import datetime
import sys
import os

def convert_csv_to_json(csv_file_path):
    """Convert CSV attendance data to JSON format"""
    
    if not os.path.exists(csv_file_path):
        print(f"✗ CSV file not found: {csv_file_path}")
        return None
    
    try:
        records = []
        
        with open(csv_file_path, 'r', encoding='utf-8') as csvfile:
            # Try to detect the delimiter
            sample = csvfile.read(1024)
            csvfile.seek(0)
            
            # Common delimiters to try
            delimiters = [',', ';', '\t']
            detected_delimiter = ','
            
            for delimiter in delimiters:
                if delimiter in sample:
                    detected_delimiter = delimiter
                    break
            
            reader = csv.DictReader(csvfile, delimiter=detected_delimiter)
            
            for row in reader:
                # Clean and process the data
                record = {}
                
                # Map common column names
                for key, value in row.items():
                    key_lower = key.lower().strip()
                    
                    if 'user' in key_lower or 'id' in key_lower or 'enroll' in key_lower:
                        record['UserId'] = value.strip()
                    elif 'time' in key_lower or 'date' in key_lower:
                        record['LogTime'] = value.strip()
                    elif 'verify' in key_lower or 'mode' in key_lower:
                        record['VerifyMode'] = value.strip()
                    elif 'in' in key_lower and 'out' in key_lower:
                        record['InOutMode'] = value.strip()
                    elif 'work' in key_lower:
                        record['WorkCode'] = value.strip()
                    else:
                        # Keep original column name
                        record[key.strip()] = value.strip()
                
                records.append(record)
        
        # Create the final JSON structure
        result = {
            "Success": True,
            "Message": f"Successfully converted {len(records)} records from CSV",
            "TotalRecords": len(records),
            "Records": records,
            "ExtractionTime": datetime.datetime.now().isoformat(),
            "SourceFile": csv_file_path
        }
        
        return result
        
    except Exception as e:
        print(f"✗ Error converting CSV: {e}")
        return None

def create_sample_csv():
    """Create a sample CSV file with the expected format"""
    sample_data = [
        {
            'UserId': '12345',
            'LogTime': '2024-01-15 09:00:00',
            'VerifyMode': 'Fingerprint',
            'InOutMode': 'Check In',
            'WorkCode': '0'
        },
        {
            'UserId': '12345',
            'LogTime': '2024-01-15 17:30:00',
            'VerifyMode': 'Fingerprint',
            'InOutMode': 'Check Out',
            'WorkCode': '0'
        }
    ]
    
    with open('sample_attendance.csv', 'w', newline='', encoding='utf-8') as csvfile:
        if sample_data:
            fieldnames = sample_data[0].keys()
            writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
            writer.writeheader()
            writer.writerows(sample_data)
    
    print("✓ Created sample_attendance.csv")
    print("Use this as a template for your exported data")

def main():
    """Main function"""
    print("=== CSV to JSON Converter ===")
    print()
    
    if len(sys.argv) > 1:
        csv_file = sys.argv[1]
    else:
        # Look for common CSV files
        csv_files = ['attendance.csv', 'attendance_data.csv', 'sample_attendance.csv']
        csv_file = None
        
        for file in csv_files:
            if os.path.exists(file):
                csv_file = file
                break
        
        if not csv_file:
            print("No CSV file found. Creating sample file...")
            create_sample_csv()
            print()
            print("Instructions:")
            print("1. Use the sample application to export attendance data")
            print("2. Save the exported data as 'attendance.csv'")
            print("3. Run this script again to convert to JSON")
            return
    
    print(f"Converting: {csv_file}")
    result = convert_csv_to_json(csv_file)
    
    if result:
        # Output JSON
        json_output = json.dumps(result, indent=2, default=str)
        print("=== JSON OUTPUT ===")
        print(json_output)
        
        # Save to file
        output_file = 'attendance_data.json'
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(json_output)
        
        print()
        print(f"✓ Data saved to: {output_file}")
    else:
        print("✗ Conversion failed")
    
    print()
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()

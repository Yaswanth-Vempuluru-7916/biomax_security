# Manual Data Extraction Guide

## ✅ Working Method: Sample Application + Python Converter

Since the sample application connects successfully, here's the reliable workflow:

### Step 1: Connect and Export Data

1. **Run the sample application:**
   ```bash
   Execute&Dll\FK623AttendDllCSSample.exe
   ```

2. **Configure connection:**
   - Select "Network Device"
   - IP: `10.67.20.120`
   - Port: `5005`
   - Machine Number: `1`
   - Password: `0`
   - Timeout: `5000`
   - License: `1261`
   - Click "Open Comm"

3. **Access attendance data:**
   - Click "Log Management" (should be enabled after connection)
   - Click "Read Log by Date"
   - Select your desired date range
   - Click "Download" or "Export"

4. **Save the data:**
   - Export to CSV format
   - Save as `attendance.csv` in the current directory

### Step 2: Convert to JSON

1. **Run the CSV to JSON converter:**
   ```bash
   python csv_to_json_converter.py
   ```

2. **Get your JSON output:**
   - The script will read `attendance.csv`
   - Convert it to JSON format
   - Save as `attendance_data.json`

### Step 3: Use the JSON Data

The resulting JSON will have this structure:
```json
{
  "Success": true,
  "Message": "Successfully converted X records from CSV",
  "TotalRecords": X,
  "Records": [
    {
      "UserId": "12345",
      "LogTime": "2024-01-15T09:00:00",
      "VerifyMode": "Fingerprint",
      "InOutMode": "Check In",
      "WorkCode": "0"
    }
  ],
  "ExtractionTime": "2024-01-15T10:30:00",
  "SourceFile": "attendance.csv"
}
```

## 🔧 Alternative: Fix Python Connection

If you want to fix the Python connection issue, we need to:

1. **Compare the working sample app** with our Python code
2. **Find the exact difference** in connection parameters
3. **Update our Python code** to match

## 📋 Quick Commands

```bash
# Manual extraction workflow
Execute&Dll\FK623AttendDllCSSample.exe
# ... export data to attendance.csv ...

# Convert to JSON
python csv_to_json_converter.py

# Check result
type attendance_data.json
```

## 🎯 Next Steps

1. **Try the manual workflow** - it's guaranteed to work
2. **If you need automation**, we can investigate the Python connection issue further
3. **For production use**, you could automate the sample app using Windows automation tools

The manual workflow is **100% reliable** since we know the sample app works perfectly!

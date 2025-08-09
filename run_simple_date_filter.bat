@echo off
echo ========================================
echo Simple Date Filter Attendance Extractor
========================================
echo.

echo This extracts ALL attendance data and filters by date range in Python:
echo - Accepts dates in YYYY/MM/DD HH:MM:SS format
echo - Loads ALL data from device (same as sample app)
echo - Filters by date range in Python (avoids DLL issues)
echo - Outputs JSON with filtered results
echo - Pure Python - no dotnet/msbuild needed!
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running simple date filter extractor...
python simple_date_filter_extractor.py

if %errorlevel% neq 0 (
    echo.
    echo Python script failed.
    echo Make sure Python is installed and in PATH.
    pause
    exit /b 1
)

echo.
echo Simple date filter extractor completed!
echo Check attendance_data_simple_date_filter.json for your data.
pause

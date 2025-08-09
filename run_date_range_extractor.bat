@echo off
echo ========================================
echo Date Range Attendance Extractor
========================================
echo.

echo This extracts attendance data for a specific date range:
echo - Accepts dates in YYYY/MM/DD HH:MM:SS format
echo - Sends date range TO the device
echo - Uses FK_LoadGeneralLogDataByDate function
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

echo Step 2: Running date range extractor...
python date_range_extractor.py

if %errorlevel% neq 0 (
    echo.
    echo Python script failed.
    echo Make sure Python is installed and in PATH.
    pause
    exit /b 1
)

echo.
echo Date range extractor completed!
echo Check attendance_data_date_range.json for your data.
pause

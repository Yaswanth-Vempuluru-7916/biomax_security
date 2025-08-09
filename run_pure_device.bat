@echo off
echo ========================================
echo Pure Device Attendance Data Extractor
========================================
echo.

echo This extractor gets data DIRECTLY from the device:
echo - Connects to device: 10.67.20.120:5005
echo - Loads data directly from device memory
echo - Tries both numeric and string ID methods
echo - NO pre-generated files used
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running pure device extractor...
python pure_device_extractor.py

echo.
echo Pure device extractor completed!
echo Check attendance_data_from_device.json for your data.
pause

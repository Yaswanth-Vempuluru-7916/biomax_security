@echo off
echo ========================================
echo Working Python Attendance Extractor
========================================
echo.

echo This is a WORKING Python solution:
echo - Uses numeric ID method only (avoids string buffer issues)
echo - Same connection parameters as sample app
echo - Same function calls as sample app
echo - Outputs JSON directly from device
echo - Pure Python - no dotnet/msbuild needed!
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running working Python extractor...
python working_python_extractor.py

if %errorlevel% neq 0 (
    echo.
    echo Python script failed.
    echo Make sure Python is installed and in PATH.
    pause
    exit /b 1
)

echo.
echo Working Python extractor completed!
echo Check attendance_data_working_python.json for your data.
pause

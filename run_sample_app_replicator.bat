@echo off
echo ========================================
echo Sample App Replicator
========================================
echo.

echo This replicates the EXACT same process as the sample app:
echo - Same connection parameters
echo - Same function calls
echo - Same logic flow
echo - Outputs JSON instead of Log.txt
echo - NO UI interaction needed
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running sample app replicator...
python sample_app_replicator.py

if %errorlevel% neq 0 (
    echo.
    echo Python script failed.
    echo Make sure Python is installed and in PATH.
    echo.
    echo Alternative: Use the working solution (sample app + JSON conversion)
    echo Run: .\run_working_solution.bat
    pause
    exit /b 1
)

echo.
echo Sample app replicator completed!
echo Check attendance_data_sample_app_replicator.json for your data.
pause

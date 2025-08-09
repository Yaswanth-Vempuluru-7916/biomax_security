@echo off
echo ========================================
echo Ultimate Attendance Data Extractor
========================================
echo.

echo This ultimate extractor provides:
echo - IMMEDIATE working solution (Log.txt conversion)
echo - Device extraction attempts (both numeric and string ID)
echo - Multiple output files for comparison
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running ultimate extractor...
python ultimate_extractor.py

echo.
echo Ultimate extractor completed!
echo Check the generated JSON files for your data.
pause

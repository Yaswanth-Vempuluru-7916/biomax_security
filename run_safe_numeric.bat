@echo off
echo ========================================
echo Safe Numeric Python Extractor
========================================
echo.

echo This version uses ONLY numeric ID functions to avoid string buffer issues:
echo - No string buffer manipulation
echo - Only reads data (no writing to device)
echo - Uses proven numeric ID function
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running safe numeric Python extractor...
python safe_numeric_extractor.py

echo.
echo Safe numeric extractor completed!
pause

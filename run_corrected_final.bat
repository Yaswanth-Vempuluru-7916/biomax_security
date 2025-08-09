@echo off
echo ========================================
echo Corrected Final Python Extractor
========================================
echo.

echo This version fixes ALL parameter issues based on SDK analysis:
echo - Proper string pre-allocation (like C# code)
echo - Correct parameter types and signatures
echo - Proper buffer management
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Running corrected final Python extractor...
python corrected_final_extractor.py

echo.
echo Corrected final extractor completed!
pause

@echo off
echo ========================================
echo Final Python Attendance Data Extractor
========================================
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\FK623Attend.dll" .
copy "Execute&Dll\FKAttend.dll" .
copy "Execute&Dll\FKViaDev.dll" .
copy "Execute&Dll\FaceDataConv.dll" .
copy "Execute&Dll\FpDataConv.dll" .
copy "Execute&Dll\FKPwdEncDec.dll" .
copy "Execute&Dll\LFWViaDev.dll" .
copy "Execute&Dll\adodb.dll" .
echo DLL files copied!
echo.

echo Step 2: Running final Python extractor...
echo This version has correct function signatures for both numeric and string ID devices
echo.
python final_python_extractor.py

echo.
echo Final extractor completed!
pause

@echo off
echo ========================================
echo Corrected Python Attendance Data Extractor
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

echo Step 2: Running corrected Python extractor...
echo This version handles both numeric and string ID devices
echo.
python corrected_python_extractor.py

echo.
echo Corrected extractor completed!
pause

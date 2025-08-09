@echo off
echo ========================================
echo Fixed Python Attendance Data Extractor
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

echo Step 2: Running fixed Python extractor...
echo This version uses exact same parameters as the working sample app
echo.
python fixed_python_extractor.py

echo.
echo Fixed extractor completed!
pause

@echo off
echo ========================================
echo Multi-Connection Test
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

echo Step 2: Running multi-connection test...
python multi_connection_test.py

echo.
echo Multi-connection test completed!
pause

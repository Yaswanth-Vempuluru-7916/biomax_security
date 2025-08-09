@echo off
echo ========================================
echo Simple Python Attendance Data Extractor
========================================
echo.

echo Step 1: Copying ALL required DLL files...
copy "Execute&Dll\FK623Attend.dll" .
copy "Execute&Dll\FKAttend.dll" .
copy "Execute&Dll\FKViaDev.dll" .
copy "Execute&Dll\FaceDataConv.dll" .
copy "Execute&Dll\FpDataConv.dll" .
copy "Execute&Dll\FKPwdEncDec.dll" .
copy "Execute&Dll\LFWViaDev.dll" .
copy "Execute&Dll\adodb.dll" .
copy "Execute&Dll\AxImage.ocx" .
copy "Execute&Dll\AxInterop.AXIMAGELib.dll" .
copy "Execute&Dll\AxInterop.RealSvrOcxTcpLib.dll" .
copy "Execute&Dll\Interop.AXIMAGELib.dll" .
copy "Execute&Dll\Interop.RealSvrOcxTcpLib.dll" .
copy "Execute&Dll\RealSvrOcxTcp.ocx" .
copy "Execute&Dll\MSDATGRD.OCX" .
echo All DLL files copied successfully!
echo.

echo Step 2: Running simple Python extractor...
python simple_python_extractor.py

echo.
echo Press any key to exit...
pause





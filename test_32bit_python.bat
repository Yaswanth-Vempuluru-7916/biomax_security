@echo off
echo ========================================
echo Testing 32-bit Python DLL Loading
========================================
echo.

echo Step 1: Copying DLL files...
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

echo Step 2: Checking Python architecture...
python -c "import platform; print('Python Architecture:', platform.architecture()[0])"

echo.
echo Step 3: Testing DLL load...
python -c "import ctypes; dll = ctypes.CDLL('FK623Attend.dll'); print('✓ DLL loaded successfully!')"

echo.
echo If you see "DLL loaded successfully!" above, then 32-bit Python works!
echo If you see an error, you need to install 32-bit Python.
echo.
echo Press any key to exit...
pause





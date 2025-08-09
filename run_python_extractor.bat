@echo off
echo ========================================
echo Python Attendance Data Extractor
echo ========================================
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

echo Step 2: Checking for Python...
python --version >nul 2>nul
if %errorlevel% equ 0 (
    echo Found Python, running extractor...
    python python_extractor.py
) else (
    echo Python not found in PATH.
    echo.
    echo ========================================
    echo Python Not Found - Alternative Solutions
    echo ========================================
    echo.
    echo Option 1: Install Python (Recommended)
    echo - Download from: https://www.python.org/downloads/
    echo - Make sure to check "Add Python to PATH" during installation
    echo - Then run this script again
    echo.
    echo Option 2: Use the existing sample application
    echo - Run: Execute&Dll\FK623AttendDllCSSample.exe
    echo - Enter IP: 10.67.20.120
    echo - Enter Port: 5005
    echo - Click "Open Comm"
    echo - Go to "Log" tab and download data
    echo.
    echo Option 3: Try the C# compiler approach
    echo - Run: extract_with_sample.bat
    echo.
)

echo.
echo Press any key to exit...
pause

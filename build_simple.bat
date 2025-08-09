@echo off
echo ========================================
echo Building Simple Attendance API
echo ========================================

REM Check if MSBuild is available
where msbuild >nul 2>nul
if %errorlevel% neq 0 (
    echo MSBuild not found. Please ensure Visual Studio or .NET Framework SDK is installed.
    echo.
    echo Alternative: Open the solution in Visual Studio and build from there.
    pause
    exit /b 1
)

REM Clean previous build
if exist bin rmdir /s /q bin
if exist obj rmdir /s /q obj

REM Copy required DLLs from Execute&Dll folder
echo Copying required DLLs from Execute&Dll folder...
if exist "Execute&Dll\FK623Attend.dll" (
    copy "Execute&Dll\FK623Attend.dll" .
    echo ✓ FK623Attend.dll copied
) else (
    echo ✗ FK623Attend.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\FKAttend.dll" (
    copy "Execute&Dll\FKAttend.dll" .
    echo ✓ FKAttend.dll copied
) else (
    echo ✗ FKAttend.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\FKPwdEncDec.dll" (
    copy "Execute&Dll\FKPwdEncDec.dll" .
    echo ✓ FKPwdEncDec.dll copied
) else (
    echo ✗ FKPwdEncDec.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\FKViaDev.dll" (
    copy "Execute&Dll\FKViaDev.dll" .
    echo ✓ FKViaDev.dll copied
) else (
    echo ✗ FKViaDev.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\FpDataConv.dll" (
    copy "Execute&Dll\FpDataConv.dll" .
    echo ✓ FpDataConv.dll copied
) else (
    echo ✗ FpDataConv.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\FaceDataConv.dll" (
    copy "Execute&Dll\FaceDataConv.dll" .
    echo ✓ FaceDataConv.dll copied
) else (
    echo ✗ FaceDataConv.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\Interop.AXIMAGELib.dll" (
    copy "Execute&Dll\Interop.AXIMAGELib.dll" .
    echo ✓ Interop.AXIMAGELib.dll copied
) else (
    echo ✗ Interop.AXIMAGELib.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\Interop.RealSvrOcxTcpLib.dll" (
    copy "Execute&Dll\Interop.RealSvrOcxTcpLib.dll" .
    echo ✓ Interop.RealSvrOcxTcpLib.dll copied
) else (
    echo ✗ Interop.RealSvrOcxTcpLib.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\LFWViaDev.dll" (
    copy "Execute&Dll\LFWViaDev.dll" .
    echo ✓ LFWViaDev.dll copied
) else (
    echo ✗ LFWViaDev.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\MSDATGRD.OCX" (
    copy "Execute&Dll\MSDATGRD.OCX" .
    echo ✓ MSDATGRD.OCX copied
) else (
    echo ✗ MSDATGRD.OCX not found in Execute&Dll folder
)

if exist "Execute&Dll\RealSvrOcxTcp.ocx" (
    copy "Execute&Dll\RealSvrOcxTcp.ocx" .
    echo ✓ RealSvrOcxTcp.ocx copied
) else (
    echo ✗ RealSvrOcxTcp.ocx not found in Execute&Dll folder
)

if exist "Execute&Dll\AxImage.ocx" (
    copy "Execute&Dll\AxImage.ocx" .
    echo ✓ AxImage.ocx copied
) else (
    echo ✗ AxImage.ocx not found in Execute&Dll folder
)

if exist "Execute&Dll\adodb.dll" (
    copy "Execute&Dll\adodb.dll" .
    echo ✓ adodb.dll copied
) else (
    echo ✗ adodb.dll not found in Execute&Dll folder
)

if exist "Execute&Dll\Newtonsoft.Json.dll" (
    copy "Execute&Dll\Newtonsoft.Json.dll" .
    echo ✓ Newtonsoft.Json.dll copied
) else (
    echo ✗ Newtonsoft.Json.dll not found in Execute&Dll folder
)

REM Build the simple project using solution file
echo.
echo Building SimpleAttendanceAPI project using solution file...
msbuild SimpleAttendanceAPI.sln /p:Configuration=Debug /p:Platform="Any CPU" /verbosity:minimal
if %errorlevel% neq 0 (
    echo.
    echo Build failed! Trying direct compilation...
    echo.
    
    REM Try direct compilation as fallback
    where csc >nul 2>nul
    if %errorlevel% equ 0 (
        echo Attempting direct compilation with csc.exe...
        mkdir bin\Debug 2>nul
        csc.exe /target:exe /out:bin\Debug\SimpleAttendanceAPI.exe /reference:Newtonsoft.Json.dll /reference:System.dll /reference:System.Core.dll /reference:System.Net.Http.dll /reference:System.Xml.dll /reference:System.Data.dll SimpleAttendanceAPI.cs
        if %errorlevel% neq 0 (
            echo Direct compilation also failed!
            echo.
            echo Troubleshooting tips:
            echo 1. Make sure all required DLLs are copied from Execute&Dll folder
            echo 2. Check if .NET Framework SDK is installed
            echo 3. Try running as Administrator
            echo.
            pause
            exit /b 1
        )
    ) else (
        echo Both MSBuild and csc.exe failed!
        echo.
        echo Troubleshooting tips:
        echo 1. Make sure all required DLLs are copied from Execute&Dll folder
        echo 2. Check if .NET Framework SDK is installed
        echo 3. Try running as Administrator
        echo.
        pause
        exit /b 1
    )
)

echo.
echo ========================================
echo Build successful!
echo ========================================

REM Check if executable exists
if not exist "bin\Debug\SimpleAttendanceAPI.exe" (
    echo Executable not found at bin\Debug\SimpleAttendanceAPI.exe
    echo Please check the build output above for errors.
    pause
    exit /b 1
)

echo.
echo ========================================
echo Starting Simple Attendance API Server
echo ========================================
echo.
echo The API will be available at:
echo   http://localhost:8080/api/attendance
echo   http://localhost:8080/api/attendance/all
echo   http://localhost:8080/api/device/status
echo.
echo Example usage:
echo   http://localhost:8080/api/attendance?startDate=2024-01-01&endDate=2024-01-31
echo.
echo Press Ctrl+C to stop the server.
echo.

cd bin\Debug
SimpleAttendanceAPI.exe

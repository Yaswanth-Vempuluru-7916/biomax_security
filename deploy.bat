@echo off
setlocal enabledelayedexpansion

echo ========================================
echo Simple Attendance API - Production Deploy
echo ========================================

REM Set variables
set "DEPLOY_DIR=deploy"
set "BUILD_CONFIG=Release"
set "PROJECT_NAME=SimpleAttendanceAPI"

REM Check if MSBuild is available
where msbuild >nul 2>nul
if %errorlevel% neq 0 (
    echo ERROR: MSBuild not found. Please ensure one of the following is installed:
    echo   - Visual Studio 2017 or later
    echo   - Visual Studio Build Tools
    echo   - .NET Framework 4.7.2 SDK or later
    echo.
    echo You can download Build Tools from:
    echo https://visualstudio.microsoft.com/visual-cpp-build-tools/
    pause
    exit /b 1
)

REM Verify Execute&Dll folder exists
if not exist "Execute&Dll" (
    echo ERROR: Execute&Dll folder not found!
    echo This folder contains required SDK DLLs and must be present.
    pause
    exit /b 1
)

REM Clean previous builds
echo Cleaning previous builds...
if exist bin rmdir /s /q bin 2>nul
if exist obj rmdir /s /q obj 2>nul
if exist "%DEPLOY_DIR%" rmdir /s /q "%DEPLOY_DIR%" 2>nul

REM Create deploy directory
mkdir "%DEPLOY_DIR%" 2>nul

REM Build the project in Release mode
echo.
echo Building %PROJECT_NAME% in %BUILD_CONFIG% mode...
msbuild %PROJECT_NAME%.sln /p:Configuration=%BUILD_CONFIG% /p:Platform="Any CPU" /verbosity:minimal /nologo

if %errorlevel% neq 0 (
    echo.
    echo ERROR: Build failed!
    echo.
    echo Troubleshooting tips:
    echo 1. Ensure all files in Execute&Dll folder are present
    echo 2. Check if .NET Framework 4.7.2 is installed
    echo 3. Try running as Administrator
    echo 4. Check the build output above for specific errors
    echo.
    pause
    exit /b 1
)

REM Verify build output exists
if not exist "bin\%BUILD_CONFIG%\%PROJECT_NAME%.exe" (
    echo ERROR: Build output not found at bin\%BUILD_CONFIG%\%PROJECT_NAME%.exe
    echo Please check the build output above for errors.
    pause
    exit /b 1
)

REM Copy production files to deploy directory
echo.
echo Copying production files to %DEPLOY_DIR% directory...

REM Copy main executable and config
copy "bin\%BUILD_CONFIG%\%PROJECT_NAME%.exe" "%DEPLOY_DIR%\" >nul
copy "bin\%BUILD_CONFIG%\%PROJECT_NAME%.exe.config" "%DEPLOY_DIR%\" >nul

REM Copy all required DLLs and OCX files
copy "bin\%BUILD_CONFIG%\*.dll" "%DEPLOY_DIR%\" >nul
copy "bin\%BUILD_CONFIG%\*.ocx" "%DEPLOY_DIR%\" >nul

REM Verify critical files were copied
set "MISSING_FILES="
if not exist "%DEPLOY_DIR%\%PROJECT_NAME%.exe" set "MISSING_FILES=!MISSING_FILES! %PROJECT_NAME%.exe"
if not exist "%DEPLOY_DIR%\FK623Attend.dll" set "MISSING_FILES=!MISSING_FILES! FK623Attend.dll"
if not exist "%DEPLOY_DIR%\Newtonsoft.Json.dll" set "MISSING_FILES=!MISSING_FILES! Newtonsoft.Json.dll"

if not "!MISSING_FILES!"=="" (
    echo ERROR: Critical files missing from deploy directory:!MISSING_FILES!
    echo.
    echo This indicates a build or copy issue. Please check:
    echo 1. All files exist in Execute&Dll folder
    echo 2. Build completed successfully
    echo 3. No antivirus interference
    pause
    exit /b 1
)

REM Create a simple start script for production
echo @echo off > "%DEPLOY_DIR%\start_api.bat"
echo echo Starting Simple Attendance API Server... >> "%DEPLOY_DIR%\start_api.bat"
echo echo. >> "%DEPLOY_DIR%\start_api.bat"
echo echo API endpoints available at: >> "%DEPLOY_DIR%\start_api.bat"
echo echo   http://localhost:8080/api/attendance >> "%DEPLOY_DIR%\start_api.bat"
echo echo   http://localhost:8080/api/attendance/all >> "%DEPLOY_DIR%\start_api.bat"
echo echo   http://localhost:8080/api/employees >> "%DEPLOY_DIR%\start_api.bat"
echo echo   http://localhost:8080/api/device/status >> "%DEPLOY_DIR%\start_api.bat"
echo echo. >> "%DEPLOY_DIR%\start_api.bat"
echo echo Press Ctrl+C to stop the server. >> "%DEPLOY_DIR%\start_api.bat"
echo echo. >> "%DEPLOY_DIR%\start_api.bat"
echo %PROJECT_NAME%.exe >> "%DEPLOY_DIR%\start_api.bat"

REM Create a Windows Service installation script
echo @echo off > "%DEPLOY_DIR%\install_service.bat"
echo echo Installing Simple Attendance API as Windows Service... >> "%DEPLOY_DIR%\install_service.bat"
echo echo. >> "%DEPLOY_DIR%\install_service.bat"
echo echo This requires NSSM ^(Non-Sucking Service Manager^) >> "%DEPLOY_DIR%\install_service.bat"
echo echo Download from: https://nssm.cc/download >> "%DEPLOY_DIR%\install_service.bat"
echo echo. >> "%DEPLOY_DIR%\install_service.bat"
echo echo After downloading NSSM, run these commands as Administrator: >> "%DEPLOY_DIR%\install_service.bat"
echo echo. >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm install SimpleAttendanceAPI "%%~dp0%PROJECT_NAME%.exe" >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm set SimpleAttendanceAPI AppDirectory "%%~dp0" >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm set SimpleAttendanceAPI Start SERVICE_AUTO_START >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm set SimpleAttendanceAPI AppStdout "%%~dp0logs\service.out.log" >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm set SimpleAttendanceAPI AppStderr "%%~dp0logs\service.err.log" >> "%DEPLOY_DIR%\install_service.bat"
echo echo nssm start SimpleAttendanceAPI >> "%DEPLOY_DIR%\install_service.bat"
echo echo. >> "%DEPLOY_DIR%\install_service.bat"
echo pause >> "%DEPLOY_DIR%\install_service.bat"

REM Create logs directory for service
mkdir "%DEPLOY_DIR%\logs" 2>nul

REM Display deployment summary
echo.
echo ========================================
echo Deployment Summary
echo ========================================
echo.
echo Deployment successful! Files copied to: %DEPLOY_DIR%\
echo.
echo Production files:
dir /b "%DEPLOY_DIR%\*.exe" "%DEPLOY_DIR%\*.dll" "%DEPLOY_DIR%\*.config" 2>nul
echo.
echo Deployment size:
for /f "tokens=3" %%i in ('dir "%DEPLOY_DIR%" /s /-c ^| find "bytes"') do echo   %%i bytes total
echo.
echo ========================================
echo Next Steps for Production Deployment:
echo ========================================
echo.
echo 1. Copy the entire '%DEPLOY_DIR%' folder to your production server
echo.
echo 2. On the production server, you can:
echo    Option A: Run manually using 'start_api.bat'
echo    Option B: Install as Windows Service using 'install_service.bat'
echo.
echo 3. Ensure the biometric device is accessible from the production server
echo    ^(same network or VPN connection^)
echo.
echo 4. Configure Windows Firewall to allow port 8080 if needed:
echo    netsh advfirewall firewall add rule name="SimpleAttendanceAPI" dir=in action=allow protocol=TCP localport=8080
echo.
echo 5. For production hardening, consider:
echo    - Running the service under a dedicated service account
echo    - Configuring HTTPS with a reverse proxy ^(IIS, nginx^)
echo    - Setting up monitoring and log rotation
echo    - Implementing API authentication if required
echo.
echo ========================================

pause

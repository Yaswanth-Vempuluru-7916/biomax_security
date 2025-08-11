@echo off
echo Setting up environment variables for testing...

REM Biometric Device Configuration
set DEVICE_IP=10.67.20.120
set DEVICE_PORT=5005
set MACHINE_NUMBER=1
set DEVICE_PASSWORD=0
set DEVICE_TIMEOUT=5000
set DEVICE_LICENSE=1261

REM API Server Configuration
set HTTP_PORT=8080
set ENABLE_CORS=true
set CORS_ORIGINS=*

REM Environment
set Environment=Development

echo ✓ Environment variables set for current session
echo.
echo Current configuration:
echo   Device IP: %DEVICE_IP%
echo   Device Port: %DEVICE_PORT%
echo   HTTP Port: %HTTP_PORT%
echo   CORS Enabled: %ENABLE_CORS%
echo   CORS Origins: %CORS_ORIGINS%
echo.
echo You can now run your application!
echo.

REM Keep the environment variables for this session
cmd /k

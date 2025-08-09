@echo off
echo ========================================
echo Testing Sample Application Connection
========================================
echo.

echo This will open the sample application.
echo Please follow these steps:
echo.
echo 1. In the sample app, select "Network Device"
echo 2. Enter IP: 10.67.20.120
echo 3. Enter Port: 5005
echo 4. Enter Machine Number: 1
echo 5. Enter Password: 0
echo 6. Enter Timeout: 5000
echo 7. Enter License: 1261
echo 8. Click "Open Comm"
echo.
echo If it connects successfully, we know the device works.
echo If it fails, we need to check device settings.
echo.

echo Press any key to open the sample application...
pause

echo Opening sample application...
start "" "Execute&Dll\FK623AttendDllCSSample.exe"

echo.
echo Sample application opened!
echo Please test the connection and let me know the result.
echo.
pause

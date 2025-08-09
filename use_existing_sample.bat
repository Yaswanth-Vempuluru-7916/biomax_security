@echo off
echo ========================================
echo Using Existing Sample Application
echo ========================================
echo.
echo Since MSBuild is not available, let's use the existing sample
echo application to test your device connection first.
echo.

echo Step 1: Testing device connection with existing sample...
echo.
echo This will open the sample application where you can:
echo 1. Connect to your device at 10.67.20.120:5005
echo 2. Test if the SDK works with your device
echo 3. Extract attendance data manually
echo.

echo Starting the sample application...
cd "Execute&Dll"
FK623AttendDllCSSample.exe

echo.
echo Sample application closed.
echo.
echo If the sample worked, you can:
echo 1. Install Visual Studio Community (free) to build the API server
echo 2. Or use the sample application to manually extract data
echo 3. Or I can help you create a simpler solution
echo.
pause

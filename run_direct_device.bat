@echo off
echo ========================================
echo Direct Device Attendance Data Extractor
========================================
echo.

echo This extracts data DIRECTLY from the device using C#:
echo - Connects to device: 10.67.20.120:5005
echo - Uses C# SDK (no Python ctypes issues)
echo - Outputs JSON directly from device
echo - NO pre-generated files used
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Building C# direct device extractor...
dotnet build DirectDeviceExtractor.csproj --configuration Release

if %errorlevel% neq 0 (
    echo.
    echo Building failed. Trying alternative build method...
    echo.
    echo Step 2a: Trying MSBuild...
    msbuild DirectDeviceExtractor.csproj /p:Configuration=Release /p:Platform="x86"
    
    if %errorlevel% neq 0 (
        echo.
        echo Both build methods failed.
        echo You may need to install .NET Framework SDK or Visual Studio.
        echo.
        echo Alternative: Use the working solution (sample app + JSON conversion)
        echo Run: .\run_working_solution.bat
        pause
        exit /b 1
    )
)

echo Step 3: Running direct device extractor...
if exist "bin\Release\net48\DirectDeviceExtractor.exe" (
    bin\Release\net48\DirectDeviceExtractor.exe
) else if exist "bin\Release\DirectDeviceExtractor.exe" (
    bin\Release\DirectDeviceExtractor.exe
) else (
    echo Executable not found. Build may have failed.
    pause
    exit /b 1
)

echo.
echo Direct device extractor completed!
echo Check attendance_data_direct_device.json for your data.
pause

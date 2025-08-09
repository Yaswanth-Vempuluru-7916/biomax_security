@echo off
echo ========================================
echo Automated Device Attendance Extractor
========================================
echo.

echo This AUTOMATES the sample app process:
echo - Replicates: Open Comm → Log Management → Read Log by Date
echo - Uses same C# SDK as sample app
echo - Outputs JSON instead of Log.txt
echo - NO UI interaction needed
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\*.dll" . >nul 2>&1
if %errorlevel% equ 0 (
    echo DLL files copied!
) else (
    echo Warning: Some DLL files may not have copied
)

echo Step 2: Building automated extractor...
dotnet build AutomatedDeviceExtractor.csproj --configuration Release

if %errorlevel% neq 0 (
    echo.
    echo Building failed. Trying alternative build method...
    echo.
    echo Step 2a: Trying MSBuild...
    msbuild AutomatedDeviceExtractor.csproj /p:Configuration=Release /p:Platform="x86"
    
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

echo Step 3: Running automated extractor...
if exist "bin\Release\net48\AutomatedDeviceExtractor.exe" (
    bin\Release\net48\AutomatedDeviceExtractor.exe
) else if exist "bin\Release\AutomatedDeviceExtractor.exe" (
    bin\Release\AutomatedDeviceExtractor.exe
) else (
    echo Executable not found. Build may have failed.
    pause
    exit /b 1
)

echo.
echo Automated extractor completed!
echo Check attendance_data_automated.json for your data.
pause


@echo off
echo ========================================
echo Manual Setup for Attendance Data API
echo ========================================
echo.

echo Step 1: Copying required DLL files...
copy "..\Execute&Dll\FK623Attend.dll" .
copy "..\Execute&Dll\Newtonsoft.Json.dll" .
echo Files copied successfully!
echo.

echo Step 2: Checking for build tools...
where dotnet >nul 2>nul
if %errorlevel% equ 0 (
    echo Found dotnet, using it to build...
    dotnet build AttendanceDataAPI.csproj --configuration Release
) else (
    echo dotnet not found, checking for msbuild...
    where msbuild >nul 2>nul
    if %errorlevel% equ 0 (
        echo Found msbuild, using it to build...
        msbuild AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else (
        echo ERROR: Neither dotnet nor msbuild found.
        echo Please install .NET Framework 4.7.2 or later.
        pause
        exit /b 1
    )
)

if %errorlevel% neq 0 (
    echo Build failed! Please check the errors above.
    pause
    exit /b 1
)

echo.
echo Build completed successfully!
echo.

echo Step 3: Starting the API server...
echo The server will be available at: http://localhost:8080
echo Press Ctrl+C to stop the server
echo.

cd bin\Release
AttendanceDataAPI.exe

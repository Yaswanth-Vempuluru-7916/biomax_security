@echo off
echo ========================================
echo Simple Build for Attendance Data API
echo ========================================
echo.

echo Step 1: Copying required DLL files...
copy "Execute&Dll\FK623Attend.dll" .
copy "Execute&Dll\Newtonsoft.Json.dll" .
echo Files copied successfully!
echo.

echo Step 2: Looking for MSBuild...
where msbuild >nul 2>nul
if %errorlevel% equ 0 (
    echo Found MSBuild, building project...
    msbuild AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
) else (
    echo MSBuild not found in PATH.
    echo Trying to find Visual Studio MSBuild...
    
    REM Try common Visual Studio paths
    if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2019 Community MSBuild
        "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2019 Professional MSBuild
        "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2019 Enterprise MSBuild
        "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2022 Community MSBuild
        "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2022 Professional MSBuild
        "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2022 Enterprise MSBuild
        "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" AttendanceDataAPI.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else (
        echo ERROR: MSBuild not found!
        echo.
        echo Please install one of the following:
        echo 1. Visual Studio (Community, Professional, or Enterprise)
        echo 2. .NET Framework SDK
        echo 3. .NET SDK
        echo.
        echo Or try running from Visual Studio Developer Command Prompt
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

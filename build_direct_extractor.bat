@echo off
echo ========================================
echo Building Direct Data Extractor
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
    msbuild DirectDataExtractor.csproj /p:Configuration=Release /p:Platform="Any CPU"
) else (
    echo MSBuild not found in PATH.
    echo Trying to find Visual Studio MSBuild...
    
    REM Try common Visual Studio paths
    if exist "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2022 Community MSBuild
        "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" DirectDataExtractor.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
        echo Found Visual Studio 2019 Community MSBuild
        "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" DirectDataExtractor.csproj /p:Configuration=Release /p:Platform="Any CPU"
    ) else (
        echo ERROR: MSBuild not found!
        echo.
        echo Please install Visual Studio Community (free) or .NET Framework SDK
        echo Download from: https://visualstudio.microsoft.com/vs/community/
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

echo Step 3: Running the extractor...
echo This will connect to your device and extract attendance data in JSON format.
echo.

cd bin\Release
DirectDataExtractor.exe

echo.
echo Extraction completed!
pause

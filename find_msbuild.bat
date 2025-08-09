@echo off
echo ========================================
echo Finding MSBuild on your system...
echo ========================================
echo.

echo Checking for MSBuild in PATH...
where msbuild >nul 2>nul
if %errorlevel% equ 0 (
    echo Found MSBuild in PATH!
    msbuild /version
    goto :found
)

echo MSBuild not found in PATH.
echo.
echo Searching for Visual Studio installations...

REM Check for Visual Studio 2022
if exist "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2022 Community MSBuild at:
    echo C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2022 Professional MSBuild at:
    echo C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2022 Enterprise MSBuild at:
    echo C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

REM Check for Visual Studio 2019
if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2019 Community MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2019 Professional MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe" (
    echo Found Visual Studio 2019 Enterprise MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe
    goto :found
)

REM Check for Visual Studio 2017
if exist "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe" (
    echo Found Visual Studio 2017 Community MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe" (
    echo Found Visual Studio 2017 Professional MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe
    goto :found
)

if exist "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\MSBuild.exe" (
    echo Found Visual Studio 2017 Enterprise MSBuild at:
    echo C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\MSBuild.exe
    goto :found
)

echo.
echo ERROR: No MSBuild found!
echo.
echo You need to install one of the following:
echo 1. Visual Studio Community (Free): https://visualstudio.microsoft.com/vs/community/
echo 2. .NET Framework SDK
echo 3. .NET SDK
echo.
echo Or use the existing sample application instead.
pause
exit /b 1

:found
echo.
echo MSBuild found successfully!
echo You can now use the full path to build the project.
pause

# Simple Attendance API - Production Deploy Script
# PowerShell version for better Windows Server compatibility

param(
    [string]$Configuration = "Release",
    [string]$DeployDir = "deploy",
    [switch]$SkipBuild = $false,
    [switch]$Help
)

if ($Help) {
    Write-Host @"
Simple Attendance API - Production Deploy Script

USAGE:
    .\deploy.ps1 [-Configuration <Debug|Release>] [-DeployDir <path>] [-SkipBuild] [-Help]

PARAMETERS:
    -Configuration   Build configuration (Default: Release)
    -DeployDir       Deployment directory (Default: deploy)
    -SkipBuild       Skip the build step and use existing binaries
    -Help            Show this help message

EXAMPLES:
    .\deploy.ps1                           # Standard deployment
    .\deploy.ps1 -Configuration Debug      # Deploy debug build
    .\deploy.ps1 -DeployDir "C:\MyApp"     # Deploy to custom directory
    .\deploy.ps1 -SkipBuild                # Skip build, deploy existing binaries
"@
    exit 0
}

$ErrorActionPreference = "Stop"

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Simple Attendance API - Production Deploy" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$ProjectName = "SimpleAttendanceAPI"
$StartTime = Get-Date

try {
    # Verify MSBuild availability
    if (-not $SkipBuild) {
        Write-Host "Checking for MSBuild..." -ForegroundColor Yellow
        
        $msbuild = Get-Command msbuild -ErrorAction SilentlyContinue
        if (-not $msbuild) {
            throw @"
MSBuild not found! Please ensure one of the following is installed:
  - Visual Studio 2017 or later
  - Visual Studio Build Tools
  - .NET Framework 4.7.2 SDK or later

Download Build Tools from: https://visualstudio.microsoft.com/visual-cpp-build-tools/
"@
        }
        Write-Host "✓ MSBuild found: $($msbuild.Source)" -ForegroundColor Green
    }

    # Verify Execute&Dll folder
    Write-Host "Verifying SDK dependencies..." -ForegroundColor Yellow
    if (-not (Test-Path "Execute&Dll")) {
        throw "Execute&Dll folder not found! This folder contains required SDK DLLs and must be present."
    }
    
    $requiredDlls = @("FK623Attend.dll", "Newtonsoft.Json.dll", "FKAttend.dll")
    foreach ($dll in $requiredDlls) {
        if (-not (Test-Path "Execute&Dll\$dll")) {
            throw "Required DLL not found: Execute&Dll\$dll"
        }
    }
    Write-Host "✓ SDK dependencies verified" -ForegroundColor Green

    # Clean previous builds
    Write-Host "Cleaning previous builds..." -ForegroundColor Yellow
    @("bin", "obj", $DeployDir) | ForEach-Object {
        if (Test-Path $_) {
            Remove-Item $_ -Recurse -Force
            Write-Host "  Removed: $_" -ForegroundColor Gray
        }
    }

    # Create deploy directory
    New-Item -ItemType Directory -Path $DeployDir -Force | Out-Null
    Write-Host "✓ Deploy directory created: $DeployDir" -ForegroundColor Green

    # Build the project
    if (-not $SkipBuild) {
        Write-Host ""
        Write-Host "Building $ProjectName in $Configuration mode..." -ForegroundColor Yellow
        
        $buildArgs = @(
            "$ProjectName.sln"
            "/p:Configuration=$Configuration"
            "/p:Platform=Any CPU"
            "/verbosity:minimal"
            "/nologo"
        )
        
        & msbuild @buildArgs
        
        if ($LASTEXITCODE -ne 0) {
            throw @"
Build failed! 

Troubleshooting tips:
1. Ensure all files in Execute&Dll folder are present
2. Check if .NET Framework 4.7.2 is installed
3. Try running as Administrator
4. Check the build output above for specific errors
"@
        }
        Write-Host "✓ Build completed successfully" -ForegroundColor Green
    }

    # Verify build output
    $exePath = "bin\$Configuration\$ProjectName.exe"
    if (-not (Test-Path $exePath)) {
        throw "Build output not found at $exePath. Please check the build output for errors."
    }

    # Copy production files
    Write-Host ""
    Write-Host "Copying production files..." -ForegroundColor Yellow
    
    $sourceDir = "bin\$Configuration"
    $filesToCopy = @(
        "$ProjectName.exe"
        "$ProjectName.exe.config"
        "*.dll"
        "*.ocx"
    )
    
    $copiedCount = 0
    foreach ($pattern in $filesToCopy) {
        $files = Get-ChildItem "$sourceDir\$pattern" -ErrorAction SilentlyContinue
        foreach ($file in $files) {
            Copy-Item $file.FullName $DeployDir
            Write-Host "  Copied: $($file.Name)" -ForegroundColor Gray
            $copiedCount++
        }
    }
    
    Write-Host "✓ Copied $copiedCount files to deployment directory" -ForegroundColor Green

    # Verify critical files
    Write-Host "Verifying deployment..." -ForegroundColor Yellow
    $criticalFiles = @("$ProjectName.exe", "FK623Attend.dll", "Newtonsoft.Json.dll")
    $missingFiles = @()
    
    foreach ($file in $criticalFiles) {
        if (-not (Test-Path "$DeployDir\$file")) {
            $missingFiles += $file
        }
    }
    
    if ($missingFiles.Count -gt 0) {
        throw "Critical files missing from deployment: $($missingFiles -join ', ')"
    }
    Write-Host "✓ All critical files present" -ForegroundColor Green

    # Create start script
    $startScript = @"
@echo off
echo Starting Simple Attendance API Server...
echo.
echo API endpoints available at:
echo   http://localhost:8080/api/attendance
echo   http://localhost:8080/api/attendance/all
echo   http://localhost:8080/api/employees  
echo   http://localhost:8080/api/device/status
echo.
echo Press Ctrl+C to stop the server.
echo.
$ProjectName.exe
"@
    
    Set-Content "$DeployDir\start_api.bat" $startScript
    Write-Host "✓ Created start_api.bat" -ForegroundColor Green

    # Create service installation script
    $serviceScript = @"
@echo off
echo Installing Simple Attendance API as Windows Service...
echo.
echo This requires NSSM (Non-Sucking Service Manager)
echo Download from: https://nssm.cc/download
echo.
echo After downloading NSSM, run these commands as Administrator:
echo.
echo nssm install SimpleAttendanceAPI "%~dp0$ProjectName.exe"
echo nssm set SimpleAttendanceAPI AppDirectory "%~dp0"
echo nssm set SimpleAttendanceAPI Start SERVICE_AUTO_START
echo nssm set SimpleAttendanceAPI AppStdout "%~dp0logs\service.out.log"
echo nssm set SimpleAttendanceAPI AppStderr "%~dp0logs\service.err.log"
echo nssm start SimpleAttendanceAPI
echo.
pause
"@
    
    Set-Content "$DeployDir\install_service.bat" $serviceScript
    Write-Host "✓ Created install_service.bat" -ForegroundColor Green

    # Create logs directory
    New-Item -ItemType Directory -Path "$DeployDir\logs" -Force | Out-Null
    Write-Host "✓ Created logs directory" -ForegroundColor Green

    # Calculate deployment statistics
    $deployedFiles = Get-ChildItem $DeployDir -File
    $totalSize = ($deployedFiles | Measure-Object -Property Length -Sum).Sum
    $deployTime = (Get-Date) - $StartTime

    # Display summary
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host "Deployment Summary" -ForegroundColor Cyan
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "Status: " -NoNewline; Write-Host "SUCCESS" -ForegroundColor Green
    Write-Host "Files deployed: $($deployedFiles.Count)"
    Write-Host "Total size: $([math]::Round($totalSize / 1MB, 2)) MB"
    Write-Host "Deploy time: $($deployTime.TotalSeconds.ToString('F1')) seconds"
    Write-Host "Deploy location: $(Resolve-Path $DeployDir)"
    Write-Host ""
    
    Write-Host "Production files:" -ForegroundColor Yellow
    $deployedFiles | Where-Object { $_.Extension -in @('.exe', '.dll', '.config') } | 
        ForEach-Object { Write-Host "  $($_.Name)" -ForegroundColor Gray }
    
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host "Next Steps for Production Deployment:" -ForegroundColor Cyan
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "1. Copy the entire '$DeployDir' folder to your production server"
    Write-Host ""
    Write-Host "2. On the production server, you can:"
    Write-Host "   Option A: Run manually using 'start_api.bat'"
    Write-Host "   Option B: Install as Windows Service using 'install_service.bat'"
    Write-Host ""
    Write-Host "3. Ensure the biometric device is accessible from the production server"
    Write-Host "   (same network or VPN connection)"
    Write-Host ""
    Write-Host "4. Configure Windows Firewall if needed:"
    Write-Host "   netsh advfirewall firewall add rule name=`"SimpleAttendanceAPI`" dir=in action=allow protocol=TCP localport=8080"
    Write-Host ""
    Write-Host "5. For production hardening, consider:"
    Write-Host "   - Running under a dedicated service account"
    Write-Host "   - Configuring HTTPS with a reverse proxy (IIS, nginx)"
    Write-Host "   - Setting up monitoring and log rotation"
    Write-Host "   - Implementing API authentication"
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Cyan

} catch {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Red
    Write-Host "DEPLOYMENT FAILED" -ForegroundColor Red
    Write-Host "========================================" -ForegroundColor Red
    Write-Host ""
    Write-Host "Error: $($_.Exception.Message)" -ForegroundColor Red
    Write-Host ""
    exit 1
}

# Simple Attendance API

A production-ready HTTP API server for accessing biometric device attendance data. This application connects to ZKTeco/Biomax compatible devices and exposes attendance logs and employee data through RESTful endpoints.

## Features

- **RESTful API**: Clean HTTP endpoints for attendance data and device management
- **Date Filtering**: Retrieve attendance records by date range
- **Employee Management**: Access employee information from the device
- **Device Status**: Check device connectivity and status
- **Production Ready**: Optimized for Windows Server deployment

## API Endpoints

- `GET /api/attendance` - Get attendance records with optional date filtering
- `GET /api/attendance/all` - Get all attendance records
- `GET /api/employees` - Get all employees from device
- `GET /api/employees/{userId}` - Get specific employee information
- `GET /api/device/status` - Check device connectivity status

### Example Usage

```bash
# Get attendance for a specific date range
curl "http://localhost:8080/api/attendance?startDate=2024-01-01&endDate=2024-01-31"

# Get all attendance records
curl "http://localhost:8080/api/attendance/all"

# Check device status
curl "http://localhost:8080/api/device/status"

# Get all employees
curl "http://localhost:8080/api/employees"
```

## System Requirements

### Development Environment
- Windows 10/11 or Windows Server 2016+
- .NET Framework 4.7.2 or later
- Visual Studio 2017+ or MSBuild Tools

### Production Environment
- Windows Server 2016+ (recommended) or Windows 10+
- .NET Framework 4.7.2 runtime
- Network connectivity to biometric device
- Port 8080 available (configurable)

### Hardware Requirements
- Minimum: 1 CPU core, 512MB RAM, 100MB disk space
- Recommended: 2+ CPU cores, 2GB RAM, 500MB disk space

## Quick Start

### Development Build

1. **Clone the repository**
   ```cmd
   git clone <repository-url>
   ```

2. **Build and run**
   ```cmd
   # Standard MSBuild
   msbuild SimpleAttendanceAPI.sln /p:Configuration=Release
   
   # Or using the deploy script
   .\deploy.bat
   ```

3. **Start the API**
   ```cmd
   cd bin\Release
   SimpleAttendanceAPI.exe
   ```

## Production Deployment

### Method 1: Using Deployment Scripts (Recommended)

#### Windows Batch Script
```cmd
# Build and create deployment package
.\deploy.bat

# Copy the 'deploy' folder to your production server
# Then on production server:
cd deploy
start_api.bat
```

#### PowerShell Script (Advanced)
```powershell
# Basic deployment
.\deploy.ps1

# Custom configuration
.\deploy.ps1 -Configuration Release -DeployDir "C:\MyApp"

# Skip build step (use existing binaries)
.\deploy.ps1 -SkipBuild
```

### Method 2: Manual MSBuild

```cmd
# Clean previous builds
rmdir /s /q bin obj deploy

# Build in Release mode
msbuild SimpleAttendanceAPI.sln /p:Configuration=Release /p:Platform="Any CPU"

# Create deployment folder
mkdir deploy
copy bin\Release\*.exe deploy\
copy bin\Release\*.dll deploy\
copy bin\Release\*.config deploy\
```

### Method 3: Visual Studio

1. Open `SimpleAttendanceAPI.sln` in Visual Studio
2. Set configuration to **Release**
3. Build → Build Solution (Ctrl+Shift+B)
4. Copy contents of `bin\Release\` to production server

## Windows Service Installation

For production environments, running as a Windows Service is recommended:

### Using NSSM (Non-Sucking Service Manager)

1. **Download NSSM** from https://nssm.cc/download
2. **Extract NSSM** to a folder in your PATH
3. **Install the service** (run as Administrator):
   ```cmd
   cd C:\path\to\your\deployment
   
   nssm install SimpleAttendanceAPI "C:\path\to\your\deployment\SimpleAttendanceAPI.exe"
   nssm set SimpleAttendanceAPI AppDirectory "C:\path\to\your\deployment"
   nssm set SimpleAttendanceAPI Start SERVICE_AUTO_START
   nssm set SimpleAttendanceAPI AppStdout "C:\path\to\your\deployment\logs\service.out.log"
   nssm set SimpleAttendanceAPI AppStderr "C:\path\to\your\deployment\logs\service.err.log"
   nssm start SimpleAttendanceAPI
   ```

4. **Verify service**:
   ```cmd
   sc query SimpleAttendanceAPI
   nssm status SimpleAttendanceAPI
   ```

### Service Management Commands
```cmd
# Start service
nssm start SimpleAttendanceAPI

# Stop service  
nssm stop SimpleAttendanceAPI

# Restart service
nssm restart SimpleAttendanceAPI

# Remove service
nssm remove SimpleAttendanceAPI confirm
```

## Configuration

### Device Connection Settings

The device connection settings are currently hardcoded in `SimpleAttendanceAPI.cs`. For production, modify these constants:

```csharp
private const string DEVICE_IP = "10.67.20.120";     // Your device IP
private const int DEVICE_PORT = 5005;                // Device port (usually 5005)
private const int MACHINE_NUMBER = 1;                // Device ID
private const int PASSWORD = 0;                      // Device password
private const int HTTP_PORT = 8080;                  // API server port
```

### Making Settings Configurable (Recommended for Production)

To use external configuration, modify the code to read from `App.config`:

```xml
<!-- Add to App.config -->
<appSettings>
  <add key="DeviceIP" value="10.67.20.120" />
  <add key="DevicePort" value="5005" />
  <add key="HTTPPort" value="8080" />
</appSettings>
```

## Network Configuration

### Firewall Rules

Allow incoming connections on the API port:

```cmd
# Windows Firewall
netsh advfirewall firewall add rule name="SimpleAttendanceAPI" dir=in action=allow protocol=TCP localport=8080

# Or through Windows Defender Firewall GUI:
# Control Panel → System and Security → Windows Defender Firewall → Advanced Settings
# Inbound Rules → New Rule → Port → TCP → Specific Local Ports: 8080
```

### Device Connectivity

Ensure the biometric device is accessible:

1. **Same Network**: Device and server on same LAN/VLAN
2. **VPN Connection**: Use site-to-site VPN for remote access
3. **Port Forwarding**: (Not recommended) Forward device port through router

Test connectivity:
```cmd
# Test device connectivity
telnet 10.67.20.120 5005

# Or using PowerShell
Test-NetConnection -ComputerName 10.67.20.120 -Port 5005
```

## Monitoring and Maintenance

### Log Files

When running as a service with NSSM, logs are written to:
- `logs\service.out.log` - Standard output
- `logs\service.err.log` - Error output

### Health Monitoring

Monitor the API health:
```bash
# Check API status
curl http://localhost:8080/api/device/status

# Expected response for healthy system:
{"Status":"Connected","Message":"Device is accessible"}
```

### Performance Monitoring

Monitor these metrics:
- **Response Time**: API endpoint response times
- **Memory Usage**: Service memory consumption
- **Device Connectivity**: Regular device status checks
- **Error Rates**: HTTP 5xx responses

## Troubleshooting

### Common Build Issues

**MSBuild not found:**
```
Solution: Install Visual Studio Build Tools or .NET Framework SDK
Download: https://visualstudio.microsoft.com/visual-cpp-build-tools/
```

**Missing DLLs:**
```
Solution: Ensure Execute&Dll folder contains all required files:
- FK623Attend.dll (primary SDK)
- Newtonsoft.Json.dll (JSON serialization)
- All other *.dll and *.ocx files
```

**Build fails with reference errors:**
```
Solution: 
1. Clean solution: delete bin/ and obj/ folders
2. Rebuild solution
3. Check .NET Framework 4.7.2 is installed
```

### Runtime Issues

**Cannot connect to device:**
```
Possible causes:
1. Network connectivity - ping device IP
2. Device port blocked - telnet to device port 5005
3. Device offline or rebooted
4. Incorrect device IP/port configuration
```

**API not accessible:**
```
Possible causes:
1. Firewall blocking port 8080
2. Port already in use by another application
3. Service not running
4. Binding to wrong interface (localhost vs 0.0.0.0)
```

**Service fails to start:**
```
Troubleshooting steps:
1. Check Windows Event Logs (Application log)
2. Review service error logs
3. Verify all DLL dependencies are present
4. Check service account permissions
5. Run executable manually to see direct error messages
```

### Device Connectivity Issues

**Device not responding:**
```bash
# Check basic connectivity
ping 10.67.20.120

# Check port accessibility  
telnet 10.67.20.120 5005

# Verify device is online via its web interface (if available)
```

**Intermittent connection issues:**
```
Solutions:
1. Implement connection retry logic
2. Check network stability
3. Verify device firmware is up to date
4. Monitor device logs for errors
```

## Security Considerations

### Production Hardening

1. **Service Account**: Run service under dedicated low-privilege account
2. **Firewall**: Restrict API access to necessary IP ranges
3. **HTTPS**: Use reverse proxy (IIS/nginx) for TLS termination
4. **Authentication**: Implement API key or JWT authentication
5. **Network Segmentation**: Place device on isolated VLAN

### Example IIS Reverse Proxy Configuration

```xml
<!-- web.config for HTTPS termination -->
<system.webServer>
  <rewrite>
    <rules>
      <rule name="ReverseProxyInboundRule" stopProcessing="true">
        <match url="(.*)" />
        <action type="Rewrite" url="http://localhost:8080/{R:1}" />
      </rule>
    </rules>
  </rewrite>
</system.webServer>
```

## Advanced Configuration

### Multiple Device Support

To support multiple devices, modify the code to:
1. Accept device ID in API endpoints
2. Maintain device configuration in database/config
3. Implement connection pooling

### Database Integration

For persistent storage:
1. Add Entity Framework or ADO.NET
2. Store attendance records in SQL Server/SQLite
3. Implement data synchronization logic

### Clustering/High Availability

For enterprise deployments:
1. Use load balancer (HAProxy/F5)
2. Deploy multiple API instances
3. Implement shared configuration store
4. Add health check endpoints

## File Structure

```
SimpleAttendanceAPI/
├── SimpleAttendanceAPI.cs      # Main application code
├── SimpleAttendanceAPI.csproj  # Project file
├── SimpleAttendanceAPI.sln     # Solution file
├── App.config                  # Application configuration
├── deploy.bat                  # Windows deployment script
├── deploy.ps1                  # PowerShell deployment script
├── README.md                   # This file
├── .gitignore                  # Git ignore rules
├── Execute&Dll/                # SDK dependencies (do not modify)
│   ├── FK623Attend.dll         # Primary SDK library
│   ├── Newtonsoft.Json.dll     # JSON serialization
│   └── ...                     # Other required DLLs and OCX files
└── Samples/                    # SDK sample code (reference only)
```

## Version History

- **1.0.0**: Initial production release
  - RESTful API endpoints
  - MSBuild compatibility
  - Production deployment scripts
  - Windows Service support

## Support

For technical support:
1. Check this README for common solutions
2. Review Windows Event Logs
3. Test device connectivity independently
4. Verify all dependencies are present

## License

This project uses the ZKTeco/Biomax SDK which may have its own licensing terms. Please ensure compliance with the device manufacturer's SDK license agreement.

---

**Note**: This application requires the proprietary biometric device SDK files located in the `Execute&Dll` folder. These files are provided by the device manufacturer and are required for the application to function.

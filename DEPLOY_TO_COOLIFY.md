# Deploy Simple Attendance API to Coolify

This guide shows how to deploy your C# biometric attendance API to Coolify, a self-hosted platform-as-a-service.

## ⚠️ Important Limitations

**Note:** This application requires Windows to run because:
- Uses Windows-specific biometric device SDK (.dll files)
- .NET Framework 4.7.2 (Windows-only)
- Direct TCP connection to biometric device hardware

**Coolify typically runs Linux containers**, so direct deployment isn't possible. Here are alternative approaches:

## 🎯 Deployment Options

### Option 1: Windows VM on Cloud Provider (Recommended)

Deploy a Windows Server VM and use Coolify's "Raw Docker" or "Custom" deployment:

#### Step 1: Create Windows VM
```bash
# Using your cloud provider (AWS, DigitalOcean, etc.)
# Create Windows Server 2019+ instance
# Minimum: 2 CPU, 4GB RAM, 20GB disk
```

#### Step 2: Setup Windows VM
```powershell
# On Windows VM - Install dependencies
# Install .NET Framework 4.7.2+
Invoke-WebRequest -Uri "https://dotnet.microsoft.com/download/dotnet-framework/net472" -OutFile "dotnetfx472.exe"
.\dotnetfx472.exe /quiet

# Install Git (if deploying from repo)
winget install Git.Git
```

#### Step 3: Deploy Application
```powershell
# Copy your deploy folder to the VM
# Or clone from git repository
git clone <your-repo-url>
cd SimpleAttendanceAPI

# Run deployment
.\deploy.bat
```

#### Step 4: Configure Coolify Proxy
```yaml
# In Coolify, create a "Custom" service
# Point to your Windows VM IP:8080
services:
  attendance-api:
    image: "custom"
    command: "proxy"
    environment:
      TARGET_URL: "http://windows-vm-ip:8080"
      PORT: 80
```

### Option 2: Container with Wine (Advanced, Not Recommended)

Attempt to run Windows .NET in Linux container using Wine:

#### Create Dockerfile
```dockerfile
# Dockerfile (experimental - may not work reliably)
FROM ubuntu:20.04

# Install Wine and dependencies
RUN apt-get update && apt-get install -y \
    wine \
    wget \
    unzip \
    && rm -rf /var/lib/apt/lists/*

# Configure Wine
ENV WINEDEBUG=-all
ENV WINEPREFIX=/opt/wine

# Install .NET Framework 4.7.2 in Wine
RUN wget -O /tmp/dotnetfx472.exe "https://download.microsoft.com/download/..."
RUN wine /tmp/dotnetfx472.exe /quiet

# Copy application
COPY deploy/ /app/
WORKDIR /app

# Expose port
EXPOSE 8080

# Run application through Wine
CMD ["wine", "SimpleAttendanceAPI.exe"]
```

**Warning:** This approach is unreliable because:
- Biometric device drivers may not work in Wine
- TCP socket operations might fail
- Performance and stability issues

### Option 3: Hybrid Architecture (Best for Production)

Create a gateway service that runs on Windows and exposes data via API:

#### Architecture:
```
Biometric Device → Windows Gateway → Linux API Service → Coolify
```

#### Step 1: Windows Gateway Service
```csharp
// Create a minimal Windows service that:
// 1. Connects to biometric device
// 2. Exposes data via HTTP API or message queue
// 3. Runs on Windows VM in same network as device

// SimpleGateway.cs
public class BiometricGateway
{
    public async Task<AttendanceData> GetAttendanceData()
    {
        // Your existing biometric device code
        return await ExtractAttendanceData();
    }
    
    // Expose via HTTP or publish to message queue
}
```

#### Step 2: Linux API Service for Coolify
```csharp
// Create ASP.NET Core service that runs on Linux
// Consumes data from Windows Gateway
// Deploy this to Coolify

public class AttendanceController : ControllerBase
{
    [HttpGet("api/attendance")]
    public async Task<IActionResult> GetAttendance()
    {
        // Call Windows Gateway or read from message queue
        var data = await gatewayClient.GetAttendanceAsync();
        return Ok(data);
    }
}
```

## 🛠️ Coolify Deployment Steps (Hybrid Approach)

### Prerequisites
- Coolify instance running
- Windows VM with your gateway service
- Network connectivity between Coolify and Windows VM

### Step 1: Create Repository for Linux Service
```bash
# Create new repository for Linux-compatible API
mkdir attendance-api-linux
cd attendance-api-linux

# Create ASP.NET Core project
dotnet new webapi
```

### Step 2: Configure Coolify Application
```yaml
# coolify.yaml
version: "3.8"
services:
  attendance-api:
    image: mcr.microsoft.com/dotnet/aspnet:6.0
    build:
      context: .
      dockerfile: Dockerfile
    ports:
      - "8080:80"
    environment:
      - ASPNETCORE_ENVIRONMENT=Production
      - GATEWAY_URL=http://windows-gateway-ip:8080
```

### Step 3: Create Dockerfile for Linux Service
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AttendanceAPI.csproj", "."]
RUN dotnet restore
COPY . .
RUN dotnet build -c Release

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AttendanceAPI.dll"]
```

### Step 4: Deploy to Coolify
```bash
# In Coolify dashboard:
# 1. Create new application
# 2. Connect to your git repository
# 3. Configure build settings:
#    - Build command: docker build -t attendance-api .
#    - Run command: automatic (from Dockerfile)
# 4. Set environment variables
# 5. Deploy
```

### Step 5: Configure Networking
```bash
# Ensure Windows Gateway is accessible
# Configure firewall rules
# Set up VPN/private network if needed
```

## 🔧 Alternative: Use Coolify for Infrastructure Only

Deploy supporting infrastructure on Coolify while keeping the Windows app separate:

### What to Deploy on Coolify:
- **PostgreSQL/MySQL** - For storing attendance data
- **Redis** - For caching and sessions  
- **Nginx** - As reverse proxy
- **Monitoring** - Grafana, Prometheus
- **Web Dashboard** - React/Vue.js frontend

### Architecture:
```
[Biometric Device] ←→ [Windows Service] 
                              ↓
                         [Database on Coolify]
                              ↓
                      [Web Dashboard on Coolify]
```

## 📱 Frontend Dashboard Deployment

Create a web dashboard that can be deployed on Coolify:

### Step 1: Create React/Vue.js App
```bash
# Create frontend application
npx create-react-app attendance-dashboard
cd attendance-dashboard

# Add API calls to your Windows service
```

### Step 2: Coolify Configuration for Frontend
```yaml
# For static site deployment
build:
  command: npm run build
  output: build/
  
# For Node.js app
runtime: nodejs
start: npm start
```

## 🚀 Recommended Production Setup

1. **Windows VM** (AWS EC2, DigitalOcean, etc.)
   - Runs your biometric attendance service
   - Connects directly to device
   - Stores data in cloud database

2. **Coolify Services:**
   - Database (PostgreSQL)
   - Web Dashboard (React/Vue)
   - API Gateway (Node.js/Go)
   - Monitoring stack

3. **Architecture Flow:**
   ```
   Device → Windows Service → Cloud DB ← Coolify Dashboard
   ```

## 🔐 Security Considerations

- **VPN:** Connect Windows VM to Coolify network via VPN
- **API Keys:** Secure communication between services
- **Firewall:** Restrict access to biometric device network
- **HTTPS:** Use TLS for all external communications

## 📋 Deployment Checklist

- [ ] Windows VM provisioned and configured
- [ ] .NET Framework 4.7.2+ installed
- [ ] Biometric device accessible from Windows VM
- [ ] Database deployed on Coolify
- [ ] API gateway service created
- [ ] Frontend dashboard deployed
- [ ] Networking and security configured
- [ ] Monitoring and logging setup

## 🆘 Troubleshooting

### Common Issues:

**Device Connection Fails:**
```bash
# Test from Windows VM
telnet device-ip 5005
ping device-ip
```

**API Gateway Timeout:**
```bash
# Check Windows service logs
# Verify network connectivity
# Test direct API calls
```

**Coolify Build Fails:**
```bash
# Check build logs in Coolify dashboard
# Verify Dockerfile syntax
# Test build locally first
```

## 📖 Additional Resources

- [Coolify Documentation](https://coolify.io/docs)
- [ASP.NET Core on Linux](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx)
- [Docker for .NET](https://docs.microsoft.com/en-us/dotnet/core/docker/introduction)

---

**Note:** Due to Windows-specific requirements, a pure Coolify deployment isn't possible. The hybrid approach provides the best balance of using Coolify's features while maintaining compatibility with your biometric device requirements.

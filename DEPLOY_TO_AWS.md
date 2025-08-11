# Deploy Simple Attendance API to AWS

This guide provides detailed steps to deploy your C# biometric attendance API to Amazon Web Services (AWS).

## 🎯 Deployment Options

### Option 1: EC2 Windows Instance (Recommended)
### Option 2: ECS with Windows Containers  
### Option 3: Hybrid Architecture (EC2 + Lambda + RDS)

---

## 🚀 Option 1: EC2 Windows Instance (Simplest)

Deploy directly on a Windows EC2 instance for full compatibility.

### Step 1: Launch EC2 Windows Instance

#### Using AWS Console:
1. **Go to EC2 Dashboard** → Launch Instance
2. **Choose AMI:** Windows Server 2019 Base or 2022 Base
3. **Instance Type:** t3.medium (2 vCPU, 4GB RAM) minimum
4. **Storage:** 30GB GP3 SSD minimum
5. **Security Group:** Create new with these rules:
   ```
   Type: RDP, Port: 3389, Source: Your IP
   Type: HTTP, Port: 8080, Source: 0.0.0.0/0 (or restricted IPs)
   Type: Custom TCP, Port: 5005, Source: Device subnet (for biometric device)
   ```

#### Using AWS CLI:
```bash
# Create security group
aws ec2 create-security-group \
  --group-name attendance-api-sg \
  --description "Security group for biometric attendance API"

# Add rules
aws ec2 authorize-security-group-ingress \
  --group-name attendance-api-sg \
  --protocol tcp --port 3389 --cidr YOUR_IP/32

aws ec2 authorize-security-group-ingress \
  --group-name attendance-api-sg \
  --protocol tcp --port 8080 --cidr 0.0.0.0/0

# Launch instance
aws ec2 run-instances \
  --image-id ami-0c02fb55956c7d316 \
  --count 1 \
  --instance-type t3.medium \
  --key-name your-key-pair \
  --security-groups attendance-api-sg \
  --block-device-mappings DeviceName=/dev/sda1,Ebs={VolumeSize=30,VolumeType=gp3}
```

### Step 2: Connect and Setup Windows Instance

#### Connect via RDP:
```bash
# Get instance public IP
aws ec2 describe-instances --filters "Name=tag:Name,Values=attendance-api"

# Get Windows password (if using key pair)
aws ec2 get-password-data --instance-id i-1234567890abcdef0 --priv-launch-key-file your-key.pem
```

#### Initial Setup on Windows Instance:
```powershell
# Update Windows
sconfig

# Install .NET Framework 4.7.2+ (if not present)
$url = "https://download.microsoft.com/download/6/E/4/6E48E8AB-DC00-419E-9704-06DD46E5F81D/NDP472-KB4054530-x86-x64-AllOS-ENU.exe"
Invoke-WebRequest -Uri $url -OutFile "NDP472.exe"
.\NDP472.exe /quiet

# Install Git (optional, for repository deployment)
winget install Git.Git

# Configure Windows Firewall
New-NetFirewallRule -DisplayName "Attendance API" -Direction Inbound -Protocol TCP -LocalPort 8080 -Action Allow
```

### Step 3: Deploy Application

#### Option A: Copy Deploy Folder
```powershell
# Copy your deploy folder to the instance via RDP or AWS CLI
# Then run:
cd C:\path\to\deploy
.\start_api.bat
```

#### Option B: Git Repository
```powershell
# Clone repository
git clone https://github.com/your-username/attendance-api.git
cd attendance-api

# Build and deploy
.\deploy.bat

# Start as service
cd deploy
.\install_service.bat
```

### Step 4: Configure as Windows Service

```powershell
# Download NSSM
Invoke-WebRequest -Uri "https://nssm.cc/release/nssm-2.24.zip" -OutFile "nssm.zip"
Expand-Archive -Path "nssm.zip" -DestinationPath "C:\nssm"

# Add to PATH
$env:PATH += ";C:\nssm\nssm-2.24\win64"

# Install service
cd C:\path\to\deploy
nssm install SimpleAttendanceAPI "C:\path\to\deploy\SimpleAttendanceAPI.exe"
nssm set SimpleAttendanceAPI AppDirectory "C:\path\to\deploy"
nssm set SimpleAttendanceAPI Start SERVICE_AUTO_START
nssm start SimpleAttendanceAPI
```

### Step 5: Configure Load Balancer (Optional)

```bash
# Create Application Load Balancer
aws elbv2 create-load-balancer \
  --name attendance-api-alb \
  --subnets subnet-12345678 subnet-87654321 \
  --security-groups sg-attendance-api

# Create target group
aws elbv2 create-target-group \
  --name attendance-api-targets \
  --protocol HTTP \
  --port 8080 \
  --vpc-id vpc-12345678 \
  --target-type instance

# Register instance
aws elbv2 register-targets \
  --target-group-arn arn:aws:elasticloadbalancing:... \
  --targets Id=i-1234567890abcdef0
```

---

## 🐳 Option 2: ECS with Windows Containers

Deploy using Amazon ECS with Windows container support.

### Step 1: Create Container Image

#### Create Dockerfile
```dockerfile
# Dockerfile for Windows containers
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019

# Set working directory
WORKDIR /app

# Copy application files
COPY deploy/ .

# Expose port
EXPOSE 8080

# Run application
CMD ["SimpleAttendanceAPI.exe"]
```

#### Build and Push to ECR
```bash
# Create ECR repository
aws ecr create-repository --repository-name attendance-api

# Get login token
aws ecr get-login-password --region us-east-1 | docker login --username AWS --password-stdin 123456789012.dkr.ecr.us-east-1.amazonaws.com

# Build image (requires Windows Docker host)
docker build -t attendance-api .

# Tag and push
docker tag attendance-api:latest 123456789012.dkr.ecr.us-east-1.amazonaws.com/attendance-api:latest
docker push 123456789012.dkr.ecr.us-east-1.amazonaws.com/attendance-api:latest
```

### Step 2: Create ECS Cluster

```bash
# Create ECS cluster
aws ecs create-cluster --cluster-name attendance-api-cluster

# Create task definition
cat > task-definition.json << EOF
{
  "family": "attendance-api",
  "networkMode": "awsvpc",
  "requiresCompatibilities": ["EC2"],
  "cpu": "1024",
  "memory": "2048",
  "executionRoleArn": "arn:aws:iam::123456789012:role/ecsTaskExecutionRole",
  "containerDefinitions": [
    {
      "name": "attendance-api",
      "image": "123456789012.dkr.ecr.us-east-1.amazonaws.com/attendance-api:latest",
      "memory": 2048,
      "portMappings": [
        {
          "containerPort": 8080,
          "protocol": "tcp"
        }
      ],
      "logConfiguration": {
        "logDriver": "awslogs",
        "options": {
          "awslogs-group": "/ecs/attendance-api",
          "awslogs-region": "us-east-1",
          "awslogs-stream-prefix": "ecs"
        }
      }
    }
  ]
}
EOF

# Register task definition
aws ecs register-task-definition --cli-input-json file://task-definition.json
```

### Step 3: Create ECS Service

```bash
# Create service
aws ecs create-service \
  --cluster attendance-api-cluster \
  --service-name attendance-api-service \
  --task-definition attendance-api:1 \
  --desired-count 1 \
  --launch-type EC2
```

---

## 🏗️ Option 3: Hybrid Architecture (Production-Ready)

Separate concerns for scalability and maintainability.

### Architecture Overview:
```
[Biometric Device] → [EC2 Windows Gateway] → [RDS Database] ← [Lambda APIs] ← [API Gateway] ← [CloudFront]
```

### Step 1: Database Setup (RDS)

```bash
# Create RDS SQL Server instance
aws rds create-db-instance \
  --db-instance-identifier attendance-db \
  --db-instance-class db.t3.micro \
  --engine sqlserver-ex \
  --master-username admin \
  --master-user-password YourPassword123! \
  --allocated-storage 20 \
  --vpc-security-group-ids sg-12345678
```

### Step 2: Windows Gateway Service (EC2)

Create a minimal Windows service that only handles device communication:

```csharp
// GatewayService.cs - Deploy on EC2 Windows
public class BiometricGateway
{
    private readonly string _connectionString;
    
    public async Task SyncAttendanceData()
    {
        // Your existing device communication code
        var records = await ExtractAttendanceFromDevice();
        
        // Store in RDS database
        await SaveToDatabase(records);
    }
}
```

### Step 3: Lambda APIs

```csharp
// AttendanceLambda.cs - Serverless API
[LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
public class AttendanceFunction
{
    public async Task<APIGatewayProxyResponse> GetAttendance(APIGatewayProxyRequest request)
    {
        // Read from RDS database
        var data = await GetAttendanceFromDatabase();
        
        return new APIGatewayProxyResponse
        {
            StatusCode = 200,
            Body = JsonSerializer.Serialize(data),
            Headers = new Dictionary<string, string>
            {
                ["Content-Type"] = "application/json"
            }
        };
    }
}
```

### Step 4: Deploy Lambda with SAM

```yaml
# template.yaml
AWSTemplateFormatVersion: '2010-09-09'
Transform: AWS::Serverless-2016-10-31

Resources:
  AttendanceFunction:
    Type: AWS::Serverless::Function
    Properties:
      CodeUri: src/
      Handler: AttendanceLambda::AttendanceFunction::GetAttendance
      Runtime: dotnet6
      Environment:
        Variables:
          CONNECTION_STRING: !Ref DatabaseConnectionString
      Events:
        GetAttendance:
          Type: Api
          Properties:
            Path: /api/attendance
            Method: get
```

Deploy:
```bash
sam build
sam deploy --guided
```

---

## 🔧 Infrastructure as Code (CloudFormation)

### Complete Stack Template

```yaml
# attendance-api-stack.yaml
AWSTemplateFormatVersion: '2010-09-09'
Description: 'Biometric Attendance API Infrastructure'

Parameters:
  KeyPairName:
    Type: AWS::EC2::KeyPair::KeyName
    Description: EC2 Key Pair for Windows instance
  
  VpcId:
    Type: AWS::EC2::VPC::Id
    Description: VPC ID for deployment
    
  SubnetIds:
    Type: List<AWS::EC2::Subnet::Id>
    Description: Subnet IDs for deployment

Resources:
  # Security Group for Windows Instance
  WindowsSecurityGroup:
    Type: AWS::EC2::SecurityGroup
    Properties:
      GroupDescription: Security group for Windows attendance API
      VpcId: !Ref VpcId
      SecurityGroupIngress:
        - IpProtocol: tcp
          FromPort: 3389
          ToPort: 3389
          CidrIp: 0.0.0.0/0
        - IpProtocol: tcp
          FromPort: 8080
          ToPort: 8080
          CidrIp: 0.0.0.0/0
        - IpProtocol: tcp
          FromPort: 5005
          ToPort: 5005
          CidrIp: 10.0.0.0/8

  # Windows EC2 Instance
  WindowsInstance:
    Type: AWS::EC2::Instance
    Properties:
      ImageId: ami-0c02fb55956c7d316  # Windows Server 2019
      InstanceType: t3.medium
      KeyName: !Ref KeyPairName
      SecurityGroupIds:
        - !Ref WindowsSecurityGroup
      SubnetId: !Select [0, !Ref SubnetIds]
      UserData:
        Fn::Base64: !Sub |
          <powershell>
          # Install .NET Framework 4.7.2
          $url = "https://download.microsoft.com/download/6/E/4/6E48E8AB-DC00-419E-9704-06DD46E5F81D/NDP472-KB4054530-x86-x64-AllOS-ENU.exe"
          Invoke-WebRequest -Uri $url -OutFile "C:\NDP472.exe"
          Start-Process -FilePath "C:\NDP472.exe" -ArgumentList "/quiet" -Wait
          
          # Configure firewall
          New-NetFirewallRule -DisplayName "Attendance API" -Direction Inbound -Protocol TCP -LocalPort 8080 -Action Allow
          </powershell>

  # RDS Database
  AttendanceDatabase:
    Type: AWS::RDS::DBInstance
    Properties:
      DBInstanceIdentifier: attendance-db
      DBInstanceClass: db.t3.micro
      Engine: sqlserver-ex
      MasterUsername: admin
      MasterUserPassword: !Ref DBPassword
      AllocatedStorage: 20
      VPCSecurityGroups:
        - !Ref DatabaseSecurityGroup
      DBSubnetGroupName: !Ref DBSubnetGroup

  # Database Security Group
  DatabaseSecurityGroup:
    Type: AWS::EC2::SecurityGroup
    Properties:
      GroupDescription: Security group for RDS database
      VpcId: !Ref VpcId
      SecurityGroupIngress:
        - IpProtocol: tcp
          FromPort: 1433
          ToPort: 1433
          SourceSecurityGroupId: !Ref WindowsSecurityGroup

  # DB Subnet Group
  DBSubnetGroup:
    Type: AWS::RDS::DBSubnetGroup
    Properties:
      DBSubnetGroupDescription: Subnet group for RDS database
      SubnetIds: !Ref SubnetIds

  # Application Load Balancer
  ApplicationLoadBalancer:
    Type: AWS::ElasticLoadBalancingV2::LoadBalancer
    Properties:
      Name: attendance-api-alb
      Scheme: internet-facing
      Type: application
      Subnets: !Ref SubnetIds
      SecurityGroups:
        - !Ref ALBSecurityGroup

  # ALB Security Group
  ALBSecurityGroup:
    Type: AWS::EC2::SecurityGroup
    Properties:
      GroupDescription: Security group for Application Load Balancer
      VpcId: !Ref VpcId
      SecurityGroupIngress:
        - IpProtocol: tcp
          FromPort: 80
          ToPort: 80
          CidrIp: 0.0.0.0/0
        - IpProtocol: tcp
          FromPort: 443
          ToPort: 443
          CidrIp: 0.0.0.0/0

Parameters:
  DBPassword:
    Type: String
    NoEcho: true
    Description: Database password
    MinLength: 8

Outputs:
  WindowsInstanceId:
    Description: Instance ID of the Windows server
    Value: !Ref WindowsInstance
    
  WindowsInstancePublicIP:
    Description: Public IP of the Windows server
    Value: !GetAtt WindowsInstance.PublicIp
    
  DatabaseEndpoint:
    Description: RDS database endpoint
    Value: !GetAtt AttendanceDatabase.Endpoint.Address
    
  LoadBalancerDNS:
    Description: Load balancer DNS name
    Value: !GetAtt ApplicationLoadBalancer.DNSName
```

Deploy the stack:
```bash
aws cloudformation deploy \
  --template-file attendance-api-stack.yaml \
  --stack-name attendance-api-infrastructure \
  --parameter-overrides \
    KeyPairName=my-key-pair \
    VpcId=vpc-12345678 \
    SubnetIds=subnet-12345678,subnet-87654321 \
    DBPassword=MySecurePassword123!
```

---

## 🔒 Security Best Practices

### 1. IAM Roles and Policies

```json
{
  "Version": "2012-10-17",
  "Statement": [
    {
      "Effect": "Allow",
      "Action": [
        "rds:DescribeDBInstances",
        "rds:Connect"
      ],
      "Resource": "arn:aws:rds:*:*:db:attendance-db"
    },
    {
      "Effect": "Allow",
      "Action": [
        "logs:CreateLogGroup",
        "logs:CreateLogStream",
        "logs:PutLogEvents"
      ],
      "Resource": "*"
    }
  ]
}
```

### 2. VPC and Network Security

```bash
# Create private subnet for database
aws ec2 create-subnet \
  --vpc-id vpc-12345678 \
  --cidr-block 10.0.2.0/24 \
  --availability-zone us-east-1a

# Create NAT Gateway for outbound access
aws ec2 create-nat-gateway \
  --subnet-id subnet-public \
  --allocation-id eipalloc-12345678
```

### 3. Encryption

```yaml
# Enable RDS encryption
AttendanceDatabase:
  Type: AWS::RDS::DBInstance
  Properties:
    StorageEncrypted: true
    KmsKeyId: !Ref DatabaseKMSKey

# Enable EBS encryption for EC2
WindowsInstance:
  Type: AWS::EC2::Instance
  Properties:
    BlockDeviceMappings:
      - DeviceName: /dev/sda1
        Ebs:
          VolumeSize: 30
          VolumeType: gp3
          Encrypted: true
```

---

## 📊 Monitoring and Logging

### CloudWatch Setup

```bash
# Create log group
aws logs create-log-group --log-group-name /aws/ec2/attendance-api

# Create CloudWatch alarm for high CPU
aws cloudwatch put-metric-alarm \
  --alarm-name "AttendanceAPI-HighCPU" \
  --alarm-description "High CPU utilization" \
  --metric-name CPUUtilization \
  --namespace AWS/EC2 \
  --statistic Average \
  --period 300 \
  --threshold 80 \
  --comparison-operator GreaterThanThreshold \
  --dimensions Name=InstanceId,Value=i-1234567890abcdef0 \
  --evaluation-periods 2
```

### Application Monitoring

```powershell
# Install CloudWatch agent on Windows instance
Invoke-WebRequest -Uri "https://s3.amazonaws.com/amazoncloudwatch-agent/amazon_linux/amd64/latest/amazon-cloudwatch-agent.zip" -OutFile "C:\cloudwatch-agent.zip"
Expand-Archive -Path "C:\cloudwatch-agent.zip" -DestinationPath "C:\CloudWatchAgent"

# Configure agent
$config = @"
{
  "logs": {
    "logs_collected": {
      "files": {
        "collect_list": [
          {
            "file_path": "C:\\path\\to\\logs\\*.log",
            "log_group_name": "/aws/ec2/attendance-api",
            "log_stream_name": "{instance_id}"
          }
        ]
      }
    }
  }
}
"@
$config | Out-File -FilePath "C:\CloudWatchAgent\config.json"
```

---

## 💰 Cost Optimization

### Instance Sizing Recommendations

| Workload | Instance Type | Monthly Cost* |
|----------|---------------|---------------|
| Development | t3.micro | ~$15 |
| Testing | t3.small | ~$30 |
| Production (Low) | t3.medium | ~$60 |
| Production (High) | m5.large | ~$120 |

*Estimated costs in us-east-1 region

### Cost-Saving Tips

1. **Use Reserved Instances** for production (up to 72% savings)
2. **Auto Scaling** for variable workloads
3. **CloudWatch Logs Retention** - Set appropriate retention periods
4. **EBS GP3** instead of GP2 for better price/performance

```bash
# Set log retention to 30 days
aws logs put-retention-policy \
  --log-group-name /aws/ec2/attendance-api \
  --retention-in-days 30
```

---

## 🚀 Deployment Automation

### GitHub Actions Workflow

```yaml
# .github/workflows/deploy-to-aws.yml
name: Deploy to AWS

on:
  push:
    branches: [main]

jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      
      - name: Configure AWS credentials
        uses: aws-actions/configure-aws-credentials@v1
        with:
          aws-access-key-id: ${{ secrets.AWS_ACCESS_KEY_ID }}
          aws-secret-access-key: ${{ secrets.AWS_SECRET_ACCESS_KEY }}
          aws-region: us-east-1
      
      - name: Deploy CloudFormation stack
        run: |
          aws cloudformation deploy \
            --template-file attendance-api-stack.yaml \
            --stack-name attendance-api-infrastructure \
            --parameter-overrides \
              KeyPairName=${{ secrets.KEY_PAIR_NAME }} \
              VpcId=${{ secrets.VPC_ID }} \
              SubnetIds=${{ secrets.SUBNET_IDS }} \
              DBPassword=${{ secrets.DB_PASSWORD }}
      
      - name: Update EC2 instance
        run: |
          # Script to update application on EC2 instance
          aws ssm send-command \
            --instance-ids i-1234567890abcdef0 \
            --document-name "AWS-RunPowerShellScript" \
            --parameters 'commands=["cd C:\app; git pull; .\deploy.bat"]'
```

---

## 🆘 Troubleshooting

### Common Issues and Solutions

#### 1. Instance Can't Connect to Device
```powershell
# Check network connectivity
Test-NetConnection -ComputerName device-ip -Port 5005

# Check firewall rules
Get-NetFirewallRule | Where DisplayName -like "*Attendance*"

# Test from within VPC
nslookup device-hostname
```

#### 2. Application Won't Start
```powershell
# Check .NET Framework version
Get-ItemProperty "HKLM:SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\" -Name Release

# Check event logs
Get-WinEvent -LogName Application | Where {$_.LevelDisplayName -eq "Error"}

# Test application manually
cd C:\path\to\deploy
.\SimpleAttendanceAPI.exe
```

#### 3. Database Connection Issues
```powershell
# Test database connectivity
Test-NetConnection -ComputerName rds-endpoint -Port 1433

# Check security groups
aws ec2 describe-security-groups --group-ids sg-12345678
```

#### 4. Load Balancer Health Checks Failing
```bash
# Check target group health
aws elbv2 describe-target-health --target-group-arn arn:aws:elasticloadbalancing:...

# Test endpoint directly
curl http://instance-ip:8080/api/device/status
```

---

## 📋 Production Deployment Checklist

- [ ] **Infrastructure**
  - [ ] VPC and subnets configured
  - [ ] Security groups properly configured
  - [ ] EC2 instance launched and configured
  - [ ] RDS database created (if using Option 3)
  - [ ] Load balancer configured (if needed)

- [ ] **Application**
  - [ ] .NET Framework 4.7.2+ installed
  - [ ] Application deployed and tested
  - [ ] Windows Service configured
  - [ ] Firewall rules configured
  - [ ] Device connectivity verified

- [ ] **Security**
  - [ ] IAM roles and policies configured
  - [ ] Security groups restrict access appropriately
  - [ ] Encryption enabled (EBS, RDS)
  - [ ] Access logging enabled

- [ ] **Monitoring**
  - [ ] CloudWatch monitoring enabled
  - [ ] Log aggregation configured
  - [ ] Alarms and notifications setup
  - [ ] Backup strategy implemented

- [ ] **Documentation**
  - [ ] Deployment procedures documented
  - [ ] Access credentials securely stored
  - [ ] Runbooks created for common issues
  - [ ] Team trained on AWS deployment

---

**🎉 Your biometric attendance API is now ready for production deployment on AWS!**

Choose the option that best fits your requirements:
- **Option 1** for simplicity and quick deployment
- **Option 2** for containerized workloads
- **Option 3** for enterprise-grade, scalable architecture

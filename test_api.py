#!/usr/bin/env python3
"""
Test script for Attendance Data API Server
This script helps verify that the API server is working correctly with your biometric device.
"""

import requests
import json
import time
from datetime import datetime, timedelta

# Configuration
API_BASE_URL = "http://localhost:8080"
DEVICE_CONFIG = {
    "IPAddress": "10.67.20.120",
    "Port": 5005,
    "MachineNumber": 1,
    "Password": 0,
    "Timeout": 5000,
    "License": 1261
}

def test_connection():
    """Test if the API server is running"""
    try:
        response = requests.get(f"{API_BASE_URL}/api/attendance/status", timeout=5)
        if response.status_code == 200:
            print("✅ API server is running")
            return True
        else:
            print(f"❌ API server returned status code: {response.status_code}")
            return False
    except requests.exceptions.ConnectionError:
        print("❌ Cannot connect to API server. Make sure it's running on http://localhost:8080")
        return False
    except Exception as e:
        print(f"❌ Error connecting to API server: {e}")
        return False

def connect_to_device():
    """Connect to the biometric device"""
    try:
        print(f"🔌 Connecting to device at {DEVICE_CONFIG['IPAddress']}:{DEVICE_CONFIG['Port']}...")
        response = requests.post(
            f"{API_BASE_URL}/api/attendance/connect",
            json=DEVICE_CONFIG,
            timeout=10
        )
        
        if response.status_code == 200:
            result = response.json()
            print(f"✅ Connected successfully! Handle: {result.get('handle')}")
            return True
        else:
            print(f"❌ Failed to connect. Status: {response.status_code}")
            print(f"Response: {response.text}")
            return False
    except Exception as e:
        print(f"❌ Error connecting to device: {e}")
        return False

def get_status():
    """Get current server status"""
    try:
        response = requests.get(f"{API_BASE_URL}/api/attendance/status")
        if response.status_code == 200:
            status = response.json()
            print(f"📊 Status: Connected={status.get('Connected')}")
            print(f"📊 Device: {status.get('DeviceIP')}:{status.get('DevicePort')}")
            print(f"📊 Total Logs: {status.get('TotalLogs')}")
            print(f"📊 Last Sync: {status.get('LastSync')}")
            return status
        else:
            print(f"❌ Failed to get status: {response.status_code}")
            return None
    except Exception as e:
        print(f"❌ Error getting status: {e}")
        return None

def sync_data():
    """Sync attendance data from device"""
    try:
        print("🔄 Syncing attendance data...")
        response = requests.post(f"{API_BASE_URL}/api/attendance/sync")
        
        if response.status_code == 200:
            result = response.json()
            print(f"✅ {result.get('message')}")
            print(f"📊 Total logs in memory: {result.get('totalLogs')}")
            return True
        else:
            print(f"❌ Failed to sync data: {response.status_code}")
            print(f"Response: {response.text}")
            return False
    except Exception as e:
        print(f"❌ Error syncing data: {e}")
        return False

def get_logs():
    """Get attendance logs"""
    try:
        print("📋 Getting attendance logs...")
        response = requests.get(f"{API_BASE_URL}/api/attendance/logs")
        
        if response.status_code == 200:
            result = response.json()
            logs = result.get('logs', [])
            print(f"✅ Retrieved {len(logs)} logs")
            
            if logs:
                print("\n📋 Recent logs:")
                for i, log in enumerate(logs[:5]):  # Show first 5 logs
                    print(f"  {i+1}. User {log['UserId']} - {log['InOutMode']} at {log['LogTime']}")
            
            return logs
        else:
            print(f"❌ Failed to get logs: {response.status_code}")
            return []
    except Exception as e:
        print(f"❌ Error getting logs: {e}")
        return []

def get_users():
    """Get user summary"""
    try:
        print("👥 Getting user summary...")
        response = requests.get(f"{API_BASE_URL}/api/attendance/users")
        
        if response.status_code == 200:
            result = response.json()
            users = result.get('users', [])
            print(f"✅ Found {len(users)} users")
            
            if users:
                print("\n👥 User summary:")
                for user in users:
                    print(f"  - User {user['UserId']}: {user['TotalLogs']} logs, last: {user['LastAttendance']}")
            
            return users
        else:
            print(f"❌ Failed to get users: {response.status_code}")
            return []
    except Exception as e:
        print(f"❌ Error getting users: {e}")
        return []

def test_filtered_logs():
    """Test filtered log retrieval"""
    try:
        # Get logs for today
        today = datetime.now().strftime("%Y-%m-%d")
        print(f"📅 Getting logs for today ({today})...")
        
        response = requests.get(f"{API_BASE_URL}/api/attendance/logs?fromDate={today}")
        
        if response.status_code == 200:
            result = response.json()
            logs = result.get('logs', [])
            print(f"✅ Found {len(logs)} logs for today")
            return True
        else:
            print(f"❌ Failed to get filtered logs: {response.status_code}")
            return False
    except Exception as e:
        print(f"❌ Error getting filtered logs: {e}")
        return False

def disconnect():
    """Disconnect from device"""
    try:
        print("🔌 Disconnecting from device...")
        response = requests.post(f"{API_BASE_URL}/api/attendance/disconnect")
        
        if response.status_code == 200:
            print("✅ Disconnected successfully")
            return True
        else:
            print(f"❌ Failed to disconnect: {response.status_code}")
            return False
    except Exception as e:
        print(f"❌ Error disconnecting: {e}")
        return False

def main():
    """Run all tests"""
    print("🧪 Attendance Data API Test Script")
    print("=" * 50)
    
    # Test 1: Check if API server is running
    if not test_connection():
        print("\n❌ Please start the API server first!")
        return
    
    # Test 2: Connect to device
    if not connect_to_device():
        print("\n❌ Failed to connect to device. Check your device configuration.")
        return
    
    # Test 3: Get status
    status = get_status()
    if not status:
        return
    
    # Test 4: Sync data
    if not sync_data():
        print("\n⚠️  Warning: Could not sync data. This might be normal if device is empty.")
    
    # Test 5: Get logs
    logs = get_logs()
    
    # Test 6: Get users
    users = get_users()
    
    # Test 7: Test filtered logs
    test_filtered_logs()
    
    # Test 8: Disconnect
    disconnect()
    
    print("\n" + "=" * 50)
    print("✅ Test completed!")
    
    if logs:
        print(f"📊 Summary: {len(logs)} attendance records found")
    else:
        print("📊 Summary: No attendance records found (device might be empty)")

if __name__ == "__main__":
    main()

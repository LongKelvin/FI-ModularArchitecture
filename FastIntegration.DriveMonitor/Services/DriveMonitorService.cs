using FastIntegration.DriveMonitor.Interfaces;

namespace FastIntegration.DriveMonitor.Services
{
    public class DriveMonitorService : IDriveMonitorService
    {
        public void MonitorDrive(string driveName, string path)
        {
            Console.WriteLine($"Monitoring {driveName}...");
            Console.WriteLine($"Path {path}...");
        }
    }
}

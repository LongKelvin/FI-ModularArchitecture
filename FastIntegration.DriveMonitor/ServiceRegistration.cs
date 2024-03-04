using FastIntegration.DriveMonitor.Interfaces;
using FastIntegration.DriveMonitor.Services;

using Microsoft.Extensions.DependencyInjection;

namespace FastIntegration.DriveMonitor
{
    public static class ServiceRegistration
    {
        public static void AddDriveMonitorService(this IServiceCollection services)
        {
            services.AddSingleton<IDriveMonitorService, DriveMonitorService>();
        }
    }
}

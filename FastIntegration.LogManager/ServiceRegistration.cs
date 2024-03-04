

using FastIntegration.LogManager.Interfaces;
using FastIntegration.LogManager.Services;

using Microsoft.Extensions.DependencyInjection;

namespace FastIntegration.DriveMonitor
{
    public static class ServiceRegistration
    {
        public static void AddLogService<T>(this IServiceCollection services) where T : class
        {
            services.AddSingleton<ILoggerService<T>>(provider =>
            {
                return new Log4NetLoggerService<T>();
            });
        }
    }
}

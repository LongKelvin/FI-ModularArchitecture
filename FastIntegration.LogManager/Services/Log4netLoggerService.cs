using FastIntegration.LogManager.Interfaces;

using log4net;

namespace FastIntegration.LogManager.Services
{
    public class Log4NetLoggerService<T> : ILoggerService<T>
    {
        private readonly ILog _logger;

        public Log4NetLoggerService()
        {
            _logger = log4net.LogManager.GetLogger(typeof(T));
        }

        public void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public void LogError(string message, Exception? ex = null)
        {
            _logger.Error(message, ex);
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }
    }
}
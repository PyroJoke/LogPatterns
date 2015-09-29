using NLog;

namespace WebApplication.LoggerHelpers
{
    public class NLogHelper : ILoggerHelper
    {
        private readonly Logger _log;

        public NLogHelper()
        {
            _log = LogManager.GetCurrentClassLogger();
        }

        public void LogMessages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _log.Info("Log4Net writes informational messages");
            }
        }
    }
}

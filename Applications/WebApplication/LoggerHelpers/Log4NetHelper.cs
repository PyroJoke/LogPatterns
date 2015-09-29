using log4net;

namespace WebApplication.LoggerHelpers
{
    public class Log4NetHelper : ILoggerHelper
    {
        private readonly ILog _log;

        public Log4NetHelper()
        {
            _log = LogManager.GetLogger(typeof(Log4NetHelper));
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

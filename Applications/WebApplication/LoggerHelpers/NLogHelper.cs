using NLog;

namespace WebApplication.LoggerHelpers
{
    public class NLogHelper : ILoggerHelper
    {
        private readonly Logger _log;
        private readonly Logger _log2;

        public NLogHelper()
        {
            _log = LogManager.GetCurrentClassLogger();
            _log2 = LogManager.GetLogger("source1");
        }

        public void LogMessages(int count)
        {
            _log2.Info("Source one emit some info");

            for (int i = 0; i < count; i++)
            {
                _log.Info("Log4Net writes informational messages");
            }
        }
    }
}

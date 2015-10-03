using Common.Logging;

namespace WebApplication.LoggerHelpers
{
    public class CommonLoggingHelper : ILoggerHelper
    {
        private readonly ILog _log;

        public CommonLoggingHelper()
        {
            _log = LogManager.GetLogger<CommonLoggingHelper>();
        }

        public void LogMessages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _log.Info("Common.Logging writes informational messages");
            }
        }
    }
}
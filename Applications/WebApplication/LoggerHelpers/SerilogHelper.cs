using Serilog;

namespace WebApplication.LoggerHelpers
{
    public class SerilogHelper : ILoggerHelper
    {
        private readonly ILogger _log;

        public SerilogHelper(string basePath)
        {
            _log = new LoggerConfiguration()
                .WriteTo.File(string.Format("{0}\\logs\\{1}", basePath, "serilog.log"))
                .CreateLogger();

            Log.Logger = _log;
        }

        public void LogMessages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Log.Logger.Information("Serilog writes informational messages {count}", i);
            }
        }
    }
}
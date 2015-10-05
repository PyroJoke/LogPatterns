using Serilog;

namespace WebApplication.LoggerHelpers
{
    public class SerilogHelper : ILoggerHelper
    {
        public SerilogHelper()
        { 
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
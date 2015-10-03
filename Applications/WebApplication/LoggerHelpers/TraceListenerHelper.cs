using System.Diagnostics;

namespace WebApplication.LoggerHelpers
{
    public class TraceListenerHelper : ILoggerHelper
    {
        public void LogMessages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Trace.TraceInformation("System Diagnostics Trace writes informational messages");
            }

            Trace.Flush();
        }
    }
}
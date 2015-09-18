using Serilog;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.ColoredConsole()
                .CreateLogger();

            logger.Information("Here is an informational message");
            logger.Debug("Some debug level info");
            logger.Error("And error level info");
        }
    }
}

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
                .WriteTo.Elasticsearch("http://localhost:9200")
                .CreateLogger();

            logger.Information("Here is an informational message");
            logger.Debug("Some debug level info");
            logger.Error("And error level info");
        }
    }
}

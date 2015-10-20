using System.Configuration;
using Raven.Client.Document;
using Serilog;

namespace AggregatorsDemo
{
    public static class LoggerConfig
    {
        public static void ConfigureLogger()
        {
            var documentStore = new DocumentStore
            {
                Url = ConfigurationManager.AppSettings["raven:documentStore:url"],
                DefaultDatabase = ConfigurationManager.AppSettings["raven:documentStore:defaultDatabase"]
            };
            documentStore.Initialize();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .WriteTo.RavenDB(documentStore)
                .CreateLogger();
        }
    }
}
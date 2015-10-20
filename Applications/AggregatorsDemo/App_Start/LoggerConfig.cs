using System.Configuration;
using Raven.Client.Document;
using Serilog;

namespace AggregatorsDemo
{
    public static class LoggerConfig
    {
        public static void ConfigureLogger()
        {
            var loggerConfig = new LoggerConfiguration()
                .ReadFrom.AppSettings();

            string ravenDocumentStoreUrl = ConfigurationManager.AppSettings["raven:documentStore:url"];
            if (!string.IsNullOrEmpty(ravenDocumentStoreUrl))
            {
                var documentStore = new DocumentStore
                {
                    Url = ravenDocumentStoreUrl,
                    DefaultDatabase = ConfigurationManager.AppSettings["raven:documentStore:defaultDatabase"]
                };
                documentStore.Initialize();

                loggerConfig.WriteTo.RavenDB(documentStore);
            }

            Log.Logger = loggerConfig.CreateLogger();
        }
    }
}
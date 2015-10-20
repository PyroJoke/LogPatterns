using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Serilog;

namespace AggregatorsDemo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            LoggerConfig.ConfigureLogger();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Log.Logger.Information("Application has been started");
        }

        protected void Application_End()
        {
            Log.Logger.Information("Application has been stopped");
        }

        protected void Application_Error()
        {
            Log.Logger.Error(Server.GetLastError(), "Unhandled Exception ocurred");
        }
    }
}

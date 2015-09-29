using System.Web.Mvc;

namespace WebApplication
{
    public class LoggingController : Controller
    {
        public string Index() {
            return "Here is the result";
        }

        public string Log4Net()
        {
            return "log4net does it's job";
        }

        public string NLog()
        {
            return "nlog does it's job";
        }

        public string ApplicationBlocksLogger()
        {
            return "application blocks logger does it's job";
        }

        public string Serilog()
        {
            return "serilog blocks logger does it's job";
        }
    }

    public class Log4NetHelper
    {
        public Log4NetHelper()
        {

        }

        public void LogMessages(int count)
        {
            for(int i = 0; i<count; i++)
            {

            }
        }
    }
}
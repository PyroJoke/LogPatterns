﻿using System.Web.Mvc;
using WebApplication.LoggerHelpers;

namespace WebApplication
{
    public class LoggingController : Controller
    {
        private const int MESSAGES_NUMBER = 1000;

        public string Index() {
            return "Hello...";
        }

        public string Loop()
        {
            for (int i = 0; i < MESSAGES_NUMBER; i++) { }
            return "Loop done";
        }

        public string Log4Net()
        {
            new Log4NetHelper().LogMessages(MESSAGES_NUMBER);
            return "log4net does it's job";
        }

        public string NLog()
        {
            new NLogHelper().LogMessages(MESSAGES_NUMBER);
            return "nlog does it's job";
        }

        public string SystemDiagnosticsTrace()
        {
            new TraceListenerHelper().LogMessages(MESSAGES_NUMBER);
            return "system diagnositcs trace does it's job";
        }

        public string Serilog()
        {
            new SerilogHelper().LogMessages(MESSAGES_NUMBER);
            return "serilog does it's job";
        }
    }
}

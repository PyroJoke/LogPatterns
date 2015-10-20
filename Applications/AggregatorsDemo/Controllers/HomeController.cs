using System;
using System.Web.Mvc;

namespace AggregatorsDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void Error()
        {
            throw new NotImplementedException("This methods is not implemented yet");
        }
    }
}

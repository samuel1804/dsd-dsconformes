using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSconformes.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Reservación Restaurant";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

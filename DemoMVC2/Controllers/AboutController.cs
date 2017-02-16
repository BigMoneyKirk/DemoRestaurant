using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC2.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DinerAddress()
        {
            string address = "the address";
            return PartialView(address);
        }
    }
}
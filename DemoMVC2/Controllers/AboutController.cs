using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diner;

namespace DemoMVC2.Controllers
{
    public class AboutController : Controller
    {
        private IMenu _menu;

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult DinerAddress()
        {
            var address = (HttpContext.Application["StevosDiner"] as Restaurant).Location;
            return PartialView(address);
        }

        public PartialViewResult Menu()
        {
            //var dinermenu = (HttpContext.Application["StevosDiner"] as Restaurant).OrderMenu.FoodItemList;
            var dinermenu = _menu.GetMenu();
            string address = "the address";
            return PartialView(address);
        }
    }
}
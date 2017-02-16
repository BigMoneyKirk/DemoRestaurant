using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "HOLLA!!";
        }

        public ViewResult Somedata()
        {
            ViewBag.text = "Hahaha!!!";
            return View();
        }
    }
}
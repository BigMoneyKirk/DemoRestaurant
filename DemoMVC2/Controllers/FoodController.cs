using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC2.Models;

namespace DemoMVC2.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ViewResult Index()
        {
            Meal m = new Meal(8, "drumstick");
            ViewBag.sucka = "starving";
            return View(m);
        }
    }
}
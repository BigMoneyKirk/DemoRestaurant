using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diner;
using DemoMVC2.Models;

namespace DemoMVC2.Controllers
{
    public class DinerController : Controller
    {
            Restaurant StevosDiner = new Restaurant("Stevo's Joint",
                new Address("567 Runs Branch Rd", "Newington", "GA", 30446),
                new Menu(new List<IFoodItem>(new[]
                {
                    new FoodItem("booty burger", 10.2, Sizes.xlarge),
                    new FoodItem("monkey sauce ham", 20.30, Sizes.small),
                    new FoodItem("shantay's dance", 4.83, Sizes.med)
                }
        )));
    
        
        public ViewResult Index()
        {
            ViewBag.dinername = "Stevo's Diner";
            ViewBag.someproperty = 1;
            ViewData["monkey"] = "some Text";
            ViewData["arr"] = new List<int>(new int[] { 1, 2, 3 });
            return View();
        }


        // GET: Diner
        public ViewResult Menu()
        {
            return View(StevosDiner);
        }

        [HttpGet]
        public ViewResult Order()
        {
            ViewData["Menu"] = StevosDiner.OrderMenu.FoodItemList;
            ViewData["Size"] = Enum.GetNames(typeof(Sizes)).ToList();
            return View();
        }

        [HttpPost]
        public ViewResult Order(Cart cart)
        {
            if (ModelState.IsValid)
            {
                return View("OrderResolved", cart);
            }
            else
            {
                return View();
            }
        }
    }
}
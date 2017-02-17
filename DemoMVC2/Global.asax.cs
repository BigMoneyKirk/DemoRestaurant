using DemoMVC2.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Diner;

namespace DemoMVC2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private Restaurant _restaurant;

        public Restaurant DinerInfo
        {
            get
            {
                if (_restaurant == null)
                {
                    _restaurant = new Restaurant("Stevo's Joint",
                new Address("567 Runs Branch Rd", "Newington", "GA", 30446),
                new Menu(new List<IFoodItem>(new[]
                {
                    new FoodItem("booty burger", 10.2, Sizes.xlarge),
                    new FoodItem("monkey sauce ham", 20.30, Sizes.small),
                    new FoodItem("shantay's dance", 4.83, Sizes.med)
                }
        )));
                }
                return _restaurant;
            }
        }

        protected void Application_Start()
        {
            Application["StevosDiner"] = DinerInfo;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutofacConfig.RegisterDI();
        }
    }
}

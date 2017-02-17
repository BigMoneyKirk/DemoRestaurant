using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Diner;

namespace DemoMVC2
{
    public class AutofacConfig
    {
        public static void RegisterDI()
        {
            var builder = new ContainerBuilder();

            // register MVC controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register dependencies
            builder.RegisterType<FoodItem>().As<IFoodItem>();
            builder.RegisterType<Menu>().As<IMenu>();

            // setup autofac as dependency resolver
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC2.Models
{
    public class Meal
    {
        public int price = 10;
        public string food = "chicken";

        public Meal(int p, string f)
        {
            price = p;
            food = f;
        }
    }
}
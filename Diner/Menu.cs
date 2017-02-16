using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner
{
    public class Menu
    {
        public Menu() { }
        public Menu(List<FoodItem> food)
        {
            FoodItemList = food;
        }

        public List<FoodItem> FoodItemList { get; set; }
    }
}

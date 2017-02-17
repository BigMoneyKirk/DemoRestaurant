using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner
{
    public class Menu : IMenu
    {
        public List<IFoodItem> _menulist;
        public Menu() { }
        public Menu(List<IFoodItem> food)
        {
            FoodItemList = food;
        }

        public List<IFoodItem> FoodItemList {
            get
            {
                if(_menulist == null)
                {
                    _menulist = new List<IFoodItem>();
                }
                return _menulist;
            }
            set { _menulist = value; }
        }

        public List<IFoodItem> GetMenu()
        {
            return FoodItemList;
        }
    }
}

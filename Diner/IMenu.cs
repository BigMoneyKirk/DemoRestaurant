using System.Collections.Generic;

namespace Diner
{
    public interface IMenu
    {
        List<IFoodItem> FoodItemList { get; set; }
        void AddItem(IFoodItem item);
        List<IFoodItem> GetMenu();
    }
}
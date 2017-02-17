using System.Collections.Generic;

namespace Diner
{
    public interface IMenu
    {
        List<IFoodItem> FoodItemList { get; set; }
    }
}
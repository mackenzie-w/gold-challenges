using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuRepository
    {
        private List<Menu> _menuItems = new List<Menu>();

        public List<Menu> GetList()
        {
            return _menuItems;
        }

        public void RemoveItemFromList(int mealnumber)
        {
            //int mealindex = _menuItems.FindIndex(meal => meal.MealNumber == mealnumber);
            foreach (Menu meal in _menuItems)
            {
                if (meal.MealNumber == mealnumber)
                {
                    _menuItems.Remove(meal);
                    break;
                }
            }
        }

        public void AddItemToList(Menu meal)
        {
            _menuItems.Add(meal);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    class FoodSelection
    {
        System.Type theType;
        public void FindItem(Food order)
        {
            if (order == typeof(Meat))
            {
                MeatSelect(order);
            }
            if (theType == (typeof(Veggie)))
            {
                VeggieSelect(order);
            }
            if (theType == (typeof(Dairy)))
            {
                DairySelect(order);
            }
            if (theType == (typeof(Bread)))
            {
                BreadSelect(order);
            }
            if (theType == (typeof(Sauce)))
            {
                SauceSelect(order);
            }
        }
    }
}

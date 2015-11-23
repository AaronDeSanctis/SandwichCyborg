using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class FoodSelection
    {
        public void FindItem(Food order)
        {
            if (order.GetType() == (typeof(Meat)))
            {
                MeatSelection meatChooser = new MeatSelection();
            }
            if (order.GetType() == (typeof(Veggie)))
            {

            }
            if (order.GetType() == (typeof(Dairy)))
            {

            }
            if (order.GetType() == (typeof(Bread)))
            {

            }
            if (order.GetType() == (typeof(Sauce)))
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class FoodSelection
    {
        public Food FindItem(Food order)
        {
            if (order.GetType() == (typeof(Meat)))
            {
                MeatSelection meatChooser = new MeatSelection();
                Food meat = meatChooser.MeatSelect(order);
                return meat;
            }
            if (order.GetType() == (typeof(Veggie)))
            {
                VeggieSelection veggieChooser = new VeggieSelection();
                Food veggie = veggieChooser.VeggieSelect(order);
                return veggie;
            }
            if (order.GetType() == (typeof(Dairy)))
            {
                DairySelection dairyChooser = new DairySelection();
                Food dairy = dairyChooser.DairySelect(order);
                return dairy;
            }
            if (order.GetType() == (typeof(Bread)))
            {
                BreadSelection breadChooser = new BreadSelection();
                Food bread = breadChooser.BreadSelect(order);
                return bread;
            }
            if (order.GetType() == (typeof(Sauce)))
            {
                SauceSelection sauceChooser = new SauceSelection();
                Food sauce = sauceChooser.SauceSelect(order);
                return sauce;
            }
            else
            {
                Lettuce lettuce = new Lettuce();
                return lettuce;
            }
        }
    }
}

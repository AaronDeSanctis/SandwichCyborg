using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class VeggieSelection
    {
        public Food VeggieSelect(Food order)
        {
            if (order.GetType() == (typeof(Olives)))
            {
                Olives olives = new Olives();
                return olives;
            }
            if (order.GetType() == (typeof(Lettuce)))
            {
                Lettuce lettuce = new Lettuce();
                return lettuce;
            }
            if (order.GetType() == (typeof(Spinach)))
            {
                Spinach spinach = new Spinach();
                return spinach;
            }
            if (order.GetType() == (typeof(Pickles)))
            {
                Pickles pickles = new Pickles();
                return pickles;
            }
            else
            {
                Lettuce lettuce = new Lettuce();
                return lettuce;
            }
        }
    }
}

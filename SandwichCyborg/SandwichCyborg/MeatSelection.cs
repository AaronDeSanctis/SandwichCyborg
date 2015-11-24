using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class MeatSelection
    {
        
        public Food MeatSelect(Food order)
        {
            if (order.GetType() == (typeof(Ham)))
            {
                Ham ham = new Ham();
                return ham;
            }
            if (order.GetType() == (typeof(Turkey)))
            {
                Turkey turkey = new Turkey();
                return turkey;
            }
            if (order.GetType() == (typeof(RoastBeef)))
            {
                RoastBeef beef = new RoastBeef();
                return beef;
            }
            if (order.GetType() == (typeof(Salami)))
            {
                Salami salami = new Salami();
                return salami;
            }
            if (order.GetType() == (typeof(Bacon)))
            {
                Bacon bacon = new Bacon();
                return bacon;
            }
            else
            {
                Ham ham = new Ham();
                return ham;
            }
        }
    }
}

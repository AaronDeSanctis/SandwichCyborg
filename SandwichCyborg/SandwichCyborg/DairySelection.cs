using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class DairySelection
    {
        public Food DairySelect(Food order)
        {
            if (order.GetType() == (typeof(ShreddedCheddar)))
            {
                ShreddedCheddar shredChed = new ShreddedCheddar();
                return shredChed;
            }
            if (order.GetType() == (typeof(Provolone)))
            {
                Provolone prov = new Provolone();
                return prov;
            }
            if (order.GetType() == (typeof(CheddarJack)))
            {
                CheddarJack chedJack = new CheddarJack();
                return chedJack;
            }
            if (order.GetType() == (typeof(ColbyJack)))
            {
                ColbyJack colbyJack = new ColbyJack();
                return colbyJack;
            }
            else
            {
                ShreddedCheddar shredChed = new ShreddedCheddar();
                return shredChed;
            }
        }
    }
}

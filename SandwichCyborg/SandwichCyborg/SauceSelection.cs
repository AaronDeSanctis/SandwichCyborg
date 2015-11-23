using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class SauceSelection
    {
        

        public SauceSelection()
        {
        
        }
        public void SauceSelect(Sauce order)
        {
            if (order.GetType() == (typeof(Mayo)))
            {

            }
            if (order.GetType() == (typeof(ChipotleMayo)))
            {

            }
        }
    }
}

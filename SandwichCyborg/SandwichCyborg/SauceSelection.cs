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
        public Sauce SauceSelect(Food order)
        {
            if (order.GetType() == (typeof(Mayo)))
            {
                Mayo mayo = new Mayo();
                return mayo;
            }
            if (order.GetType() == (typeof(ChipotleMayo)))
            {
                ChipotleMayo chipMayo = new ChipotleMayo();
                return chipMayo;
            }
            else
            {
                Mayo mayo = new Mayo();
                return mayo;
            }
        }
    }
}

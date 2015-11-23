using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    class SauceSelection
    {
        //System.Type theType;
        Food theType;
        public SauceSelection()
        {
            theType = new Meat();
        }
        public void SauceSelect(Food order)
        {
            if (typeof(Food order) == (typeof(Meat)))
            {

            }
        }
    }
}

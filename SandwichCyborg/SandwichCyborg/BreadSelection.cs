using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class BreadSelection
    {
        public Food BreadSelect(Food order)
        {
            if (order.GetType() == (typeof(SevenGrainWheatBread)))
            {
                SevenGrainWheatBread sevenWheat = new SevenGrainWheatBread();
                return sevenWheat;

            }
            if (order.GetType() == (typeof(WheatBread)))
            {
                WheatBread wheat = new WheatBread();
                return wheat;
            } 
            if (order.GetType() == (typeof(Italian)))
            {
                Italian italian = new Italian();
                return italian;
            }
            if (order.GetType() == (typeof(Tortilla)))
            {
                Tortilla tortilla = new Tortilla();
                return tortilla;
            }
            else
            {
                Italian italian = new Italian();
                return italian;
            }
        }
    }
}

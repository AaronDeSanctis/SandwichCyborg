﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    class SandwichCyborg
    {
        public List<Food> FinalSandwich;
        FoodSelection foodSelect;
        public SandwichCyborg()
        {
        }
        public void ComputeSandwich(List<Food> customerOrders)
        {
            foodSelect = new FoodSelection();
            foreach(Food order in customerOrders)
            {
                foodSelect.FindItem(order);
            }
        }

        

      

 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class SandwichCyborg
    {
        public string input;
        public List<Food> SandwichOrder;
        public List<Food> FinalSandwich;
        FoodSelection foodSelect;
        Food food;
        public SandwichCyborg()
        {
        }
        public void TakeOrder()
        {
            while (true)
            {
                input = Console.ReadLine();
                if (input == food.name)
                {
                    food = new Food();
                    SandwichOrder.Add(food);
                }
                else
                {
                    ComputeSandwich(SandwichOrder);
                    break;
                }
            }  
        }
        public void ComputeSandwich(List<Food> customerOrders)
        {
            foodSelect = new FoodSelection();
            foreach (Food order in customerOrders)
            {
                Food FoodItem = foodSelect.FindItem(order);
                FinalSandwich.Add(FoodItem);
            }
        }
        public void GiveSandwichInfo()
        {
            foreach (Food item in FinalSandwich)
            {
                Console.WriteLine(item.name);
                Console.ReadLine();
            }
        }
        public List<Food> GiveSandwich()
        {
            return FinalSandwich;
        }
    }
}

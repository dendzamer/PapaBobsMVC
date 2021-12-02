using System;
using System.Collections.Generic;
using PapaBob.Models;

namespace PapaBob.CustomClasses
{
    public class LocalCalculations
    {
        public static void CalculatePrice(Order order)
        {
            var prices = ListItems.GetAllPrices();
        
            order.Price += prices[order.Size];
            order.Price += prices[order.Crust];

            if (order.Sausage == true)
            {
                order.Price += prices["Sausage"];
            }

            if (order.Pepperoni == true)
            {
                order.Price += prices["Pepperoni"];
            }

            if (order.GreenPeppers == true)
            {
                order.Price += prices["GreenPeppers"];
            }

            if (order.Onions == true)
            {
                order.Price += prices["Onions"];
            }
        }
    }
}

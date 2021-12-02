using System;
using System.Collections.Generic;

namespace PapaBob.CustomClasses
{
    public class ListItems
    {
        public static Dictionary<string, double> GetCrusts()
        {
            Dictionary<string,double> crusts = new Dictionary<string, double>();

            crusts.Add("Regular", 0);
            crusts.Add("Thin", 0);
            crusts.Add("Thick (+ $2)", 2);

            return crusts;
        }

        public static Dictionary<string, double> GetSizes()
        {
            Dictionary<string, double> sizes = new Dictionary<string, double>();

            sizes.Add("Small (12 inch = $12)", 12);
            sizes.Add("Medium (14 inch = $14)", 14);
            sizes.Add("Large (16 inch = $16)", 16);

            return sizes;
        }

        public static Dictionary<string, double> GetAdditions()
        {
            Dictionary<string, double> additions = new Dictionary<string, double>();

            additions.Add("Sausage", 2);
            additions.Add("Pepperoni", 1.50);
            additions.Add("GreenPeppers", 1);
            additions.Add("Onions", 1);

            return additions;
        }

        public static Dictionary<string, double> GetAllPrices()
        {
            Dictionary<string, double> prices = new Dictionary<string, double>();

            foreach (var item in GetCrusts())
            {
                prices.Add(item.Key, item.Value);
            }

            foreach (var item in GetSizes())
            {
                prices.Add(item.Key, item.Value);
            }

            foreach (var item in GetAdditions())
            {
                prices.Add(item.Key, item.Value);
            }

            return prices;
        }
    }
}
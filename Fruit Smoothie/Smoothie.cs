using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Smoothie
{
    internal class Smoothie
    {
        private static Dictionary<string, decimal> prices = new Dictionary<string, decimal>()
        {
            {"Strawberries", 1.50m },
            {"Banana", 0.50m },
            {"Mango", 2.50m },
            {"Blueberries", 1m },
            {"Raspberries", 1m },
            {"Apple", 1.75m },
            {"Pineaple", 3.50m }
        };

        public static string[] Ingredients { get; set; }

        public Smoothie(IEnumerable<string> ingredients)
        {
            Ingredients= ingredients.ToArray();
        }

        
        public decimal GetCost() {
            decimal cost = 0;
            foreach (var item in Ingredients)
            {
                decimal price = 0;
                prices.TryGetValue(item, out price);
                cost+=price;
            }
            return cost;
        }
        public decimal GetPrice() {
            return Math.Round((GetCost() * (decimal)2.5), 2);
        }
        public string GetName() {
            return String.Join(" ", Ingredients.OrderBy(x=>x).Select(y=>y.EndsWith("ies")?y.Substring(0, y.Length-3)+"y":y))+(Ingredients.Length>1?" Fusion":" Smoothie");
        }
    }
}

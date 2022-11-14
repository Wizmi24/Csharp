using System;

namespace Fruit_Smoothie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a class Smoothie and do the following:
             Create a property called Ingredients.
             Create a GetCost method which calculates the total cost of the ingredients used to make the smoothie.
             Create a GetPrice method which returns the number from GetCost plus the number from GetCost multiplied by 1.5. Round to two decimal places.
             Create a GetName method which gets the ingredients and puts them in alphabetical order into a nice descriptive sentence.
             If there are multiple ingredients, add the word "Fusion" to the end but otherwise, add "Smoothie".
             Remember to change "-berries" to "-berry".
             */

            var s1 = new Smoothie(new string[] { "Banana", "Pineapple", "Apple" });
            Console.WriteLine("Get Name: " + s1.GetName());
            Console.WriteLine("Get Cost: " + s1.GetCost());
            Console.WriteLine("Get Price: " + s1.GetPrice());
            var s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine("Get Name: " + s2.GetName());
            Console.WriteLine("Get Cost: " + s2.GetCost());
            Console.WriteLine("Get Price: " + s2.GetPrice());
            var s3 = new Smoothie(new string[] { "Banana" });
            Console.WriteLine("Get Name: " + s3.GetName());
            Console.WriteLine("Get Cost: " + s3.GetCost());
            Console.WriteLine("Get Price: " + s3.GetPrice());
        }
    }
}

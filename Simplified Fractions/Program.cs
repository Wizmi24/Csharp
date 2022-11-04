using System;

namespace Simplified_Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a function that returns the simplified version of a fraction.

            int first, second;
            string result;
            bool success;
            
            do
            {
                Console.WriteLine("Enter first number");
                result = Console.ReadLine();
                success = int.TryParse(result, out first);
            } while (!success || first==0);

            do
            {
                Console.WriteLine("Enter second number");
                result = Console.ReadLine();
                success = int.TryParse(result, out second);
            } while (!success || second==0);

            int gcd = Gcd.zadanie(first, second);
            
            Console.WriteLine($"Most simplified version of {first}/{second} is {first / gcd}/{second / gcd}");
        }
    }
}

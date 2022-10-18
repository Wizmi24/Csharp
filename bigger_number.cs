using System;

namespace Cwiczenie_43._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string buf;
            bool check = false;

            do
            {
                Console.WriteLine("Enter first number: ");
                buf = Console.ReadLine();
                check=Int32.TryParse(buf, out number1);
            } while (!check);
            do
            {
                Console.WriteLine("Enter second number: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out number2);
            } while (!check);

            Console.WriteLine($"Out of {number1} and {number2} bigger is {Math.Max(number1, number2)}");
        }
    }
}

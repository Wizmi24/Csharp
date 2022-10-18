using System;

namespace Cwiczenie_68._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time");
            var userInput = Console.ReadLine();

            var time = new DateTime();

            if(DateTime.TryParse(userInput, out time))
            {
                Console.WriteLine("You entered valid time");
            }
            else Console.WriteLine("You entered invalid time");

        }
    }
}

using System;
using System.Collections.Generic;

namespace Cwiczenie_56._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            var unique = new List<int>();
            string userInput;
            do
            {
                Console.Write("Enter unique number or type quit: ");
                userInput = Console.ReadLine();
                if (userInput == "quit") break;
                var buf = Int32.TryParse(userInput, out var number);
                numberList.Add(number);
                if (!buf) Console.WriteLine("This in not a number or quit");
            } while (true);

            foreach(var element in numberList)
            {
                if (!unique.Contains(element)) unique.Add(element);
            }

            Console.WriteLine($"You added {unique.Count} unique elements");
           
        }
    }
}

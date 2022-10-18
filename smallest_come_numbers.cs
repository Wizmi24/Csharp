using System;
using System.Collections.Generic;

namespace Cwiczenie_56._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter at least 5 numbers separated by comma: ");
            var userInput = Console.ReadLine();

            var numbers = new List<int>();
            string[] elements;

            if (!String.IsNullOrWhiteSpace(userInput))
            {
                elements = userInput.Split(',');
            }
            else
            {
                Console.WriteLine("Invalid list, empty");
                return;
            }

            foreach(var number in elements)
            {
                int check;
                if (Int32.TryParse(number, out check))
                {
                    numbers.Add(check);
                }
                else
                {
                    Console.WriteLine("Invalid list, unknown character");
                    return;
                }

            }

            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid list, too few numbers");
                return;
            }

            numbers.Sort();

            Console.WriteLine($"Three smallest numbers which you entered are: {numbers[0]} {numbers[1]} {numbers[2]}");
            
            
        }
    }
}

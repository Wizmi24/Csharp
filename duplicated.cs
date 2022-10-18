using System;
using System.Collections.Generic;

namespace Cwiczenie_68._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by hyphen");
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You did not enter anything");
                return;
            }

            var numbers = userInput.Split('-');
            var isGood = new List<int>();
            
            foreach(var num in numbers)
            {
                isGood.Add(Int32.Parse(num));
            }

            isGood.Sort();

            for(int i = 0; i < isGood.Count - 2; i++)
            {
                if (isGood[i] == isGood[i + 1])
                {
                    Console.WriteLine("Duplicated "+isGood[i]);
                    return;
                }
            }
            Console.WriteLine("Everything is ok");

        }
    }
}

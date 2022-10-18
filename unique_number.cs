using System;
using System.Collections.Generic;

namespace Cwiczenie_56._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            do
            {
                Console.Write("Enter unique number: ");
                var buf = Int32.TryParse(Console.ReadLine(), out var number);
                if (buf)
                {
                    if (!numberList.Contains(number)) numberList.Add(number);
                    else Console.WriteLine("You already added this number!");
                }
                else Console.WriteLine("This in not a number");
                
            } while (numberList.Count!=5);

            numberList.Sort();

            foreach(var element in numberList)
            {
                Console.WriteLine(element);
            }
        }
    }
}

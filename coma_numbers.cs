using System;

namespace Cwiczenie_49._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, u="";

            Console.WriteLine("Enter numbers separated by comma: ");
            userInput = Console.ReadLine();

            int max = userInput[0];

            foreach(var element in userInput)
            {
                if (element!=',') u+=element;
            }

            foreach (var number in u)
            {
                if (number > max) max = number;
            }


            Console.WriteLine($"The biggest number is {max-48}");

        }
    }
}

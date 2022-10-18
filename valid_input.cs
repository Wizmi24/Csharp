using System;

namespace Cwiczenie_43._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput;
                int number;
                Console.WriteLine("Enter a number: ");
                userInput=Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    break;
                }
                else if(Int32.TryParse(userInput, out number))
                {
                    if (number >= 0 && number <= 10) Console.WriteLine("Valid");
                    else Console.WriteLine("Invalid");
                }
                else Console.WriteLine("Invalid");
                
            }
        }
    }
}

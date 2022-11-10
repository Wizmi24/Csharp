using System;

namespace String_Incrementer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a function which increments a string to create a new string.

             If the string ends with a number, the number should be incremented by 1.
             If the string doesn't end with a number, 1 should be added to the new string.
             If the number has leading zeros, the amount of digits should be considered.
             */
            Console.WriteLine("Please enter a string");
            var userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
                throw new Exception("You must enter something");

            Console.WriteLine(IncresmentString.zadanie(userInput));
        }
    }
}

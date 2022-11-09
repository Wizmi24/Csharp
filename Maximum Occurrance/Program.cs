using System;

namespace Maximum_Occurrance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Given a string text. Write a function that returns the character with the highest frequency.
             If more than 1 character has the same highest frequency, return all those characters as a comma separated string.
             If there is no repetition in characters, return "No Repetition".
             */

            Console.WriteLine("Enter string");
            var userInput=Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
                throw new Exception("You cannot enter empty string");

            
            Console.WriteLine("The most common characters in entered sentence : "+MaxOccurrance.zadanie(userInput));

        }
    }
}

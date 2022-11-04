using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                A Fibonacci Word is a specific sequence of binary digits (or symbols from any two-letter alphabet). The Fibonacci Word is formed by repeated concatenation in the same way that the Fibonacci numbers are formed by repeated addition.

                Create a function that takes a number n as an argument and returns the first n elements of the Fibonacci Word sequence.

                If n < 2, the function must return "invalid".
             */

            Console.WriteLine("Enter number of fibonacci characters");
            var number = Console.ReadLine();
            bool success=int.TryParse(number, out int result);
            if (success)
            {
                Console.WriteLine(Fibonacci.zadanie(result));
            }
            else
            {
                Console.WriteLine("You have to enter a number");
            }
        }
    }
}

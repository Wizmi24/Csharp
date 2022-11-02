using System;
using System.Linq;

namespace Reverse
{
    internal class ReverseAndNot
    {
        static void Main(string[] args)
        {
            //Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
            Console.WriteLine("Enter integer: ");
            var original = Console.ReadLine();
            bool success = int.TryParse(original, out int result);
            if (success&&result>=0)
            {
                Console.WriteLine(string.Concat(original.Reverse())+original);             
            }
            else
            {
                Console.WriteLine("You entered wrong data");
            }
        }
    }
}

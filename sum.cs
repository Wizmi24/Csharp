using System;

namespace Cwiczenie_49._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum=0;
            string buf;
            do
            {
                Console.WriteLine("Enter a number or ok to exit: ");
                buf = Console.ReadLine();
                if (Int32.TryParse(buf, out number)) sum += number;
            } while (buf != "ok");

            Console.WriteLine($"The sum of numbers you entered is {sum}");

        }
    }
}

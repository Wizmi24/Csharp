using System;

namespace Cwiczenie_49._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers=0;

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) numbers++;
            }

            Console.WriteLine($"There is {numbers} numbers between 1 to 100 that are divisible by 3");
        }
    }
}

using System;

namespace Cwiczenie_49._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, sum=1;
            string buf;
            bool check;
            do
            {
                Console.WriteLine("Enter a number: ");
                buf = Console.ReadLine();
                check=Int32.TryParse(buf, out number1);
            } while (!check||number1<=0);

            for(int i = 1; i <= number1; i++)
            {
                sum *= i;
            }

            Console.WriteLine($"Factorial of {number1} is {sum}");

        }
    }
}

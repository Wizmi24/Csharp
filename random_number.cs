using System;

namespace Cwiczenie_49._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess, guess2, answear;
            string buf;
            bool check;

            var random = new Random();

            answear=random.Next(1, 10);

            do
            {
                Console.WriteLine("Guess the number: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out guess);
            } while (!check || guess < 1 || guess > 10);

            if (guess == answear) Console.WriteLine("You won");

            do
            {
                Console.WriteLine("Guess the number second time: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out guess2);
            } while (!check || guess2 < 1 || guess2 > 10||guess==guess2);

            if (guess2 == answear) Console.WriteLine("You won");
            else Console.WriteLine($"You lost, the secret number was {answear}");

        }
    }
}

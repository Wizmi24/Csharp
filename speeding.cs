using System;

namespace Cwiczenie_43._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSpeed, currentSpeed;
            string buf;
            bool check;
            do
            {
                Console.WriteLine("Enter Speed Limit: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out maxSpeed);
            } while (!check);

            do
            {
                Console.WriteLine("Enter Current Speed: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out currentSpeed);
            } while (!check);

            var speed = currentSpeed - maxSpeed;

            if (speed <= 0) Console.WriteLine("You drove under speed limit which is ok");
            else if (speed < 65) Console.WriteLine($"You drove {speed}km/h above speed limit and got {speed / 5} demerit point");
            else Console.WriteLine($"You drove {speed}km/h above speed limit and your license got suspended");
        }
    }
}

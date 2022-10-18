using System;

namespace Cwiczenie_43._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, heigth;
            string buf;
            bool check;

            do
            {
                Console.WriteLine("Enter the width: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out width);
            } while (!check);
            do
            {
                Console.WriteLine("Enter the heigth: ");
                buf = Console.ReadLine();
                check = Int32.TryParse(buf, out heigth);
            } while (!check);

            if (width == heigth) Console.WriteLine("It's a square...");
            else if (width > heigth) Console.WriteLine("It's a landscape");
            else Console.WriteLine("It's a portrait");
        }
    }
}

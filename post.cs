using System;
using System.Collections.Generic;

namespace Cwiczenie_56._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string buf;

            do
            {
                Console.Write("Enter name: ");
                buf = Console.ReadLine();
                if (!string.IsNullOrEmpty(buf)) names.Add(buf);
            } while (!string.IsNullOrEmpty(buf));

            Console.WriteLine("You posted message");
            switch (names.Count)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine($"{names[0]} liked your post");
                    break;

                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} liked your post");
                    break;

                case > 2:
                    Console.WriteLine($"{names[0]} and {names[1]} and {names.Count-2} other liked your post");
                    break;

            }
        }
    }
}

using System;

namespace Cwiczenie_56._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, reversedName;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            var arrayName = new char[name.Length];
            for(int i = 0; i < name.Length; i++)
            {
                arrayName[i] = name[name.Length - i - 1];
            }

            reversedName = new string(arrayName);
            Console.WriteLine("Your reversed name is "+reversedName);

        }
    }
}

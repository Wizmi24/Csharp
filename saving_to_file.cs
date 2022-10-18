using System;
using System.IO;

namespace Cwiczenie_76._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some words");
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered {0} words", NumberOfWords(userInput));
        }

        public static int NumberOfWords(string userInput)
        {
            var path = @"C:\Users\wizmi\Desktop\udemy\c# poczatkujacy\Cwiczenie 76.1\tekst.txt";
            File.WriteAllText(path, userInput);
            var readText = File.ReadAllText(path);
            return readText.Split(' ').Length;
        }
    }
}

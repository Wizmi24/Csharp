using System;
using System.IO;

namespace Cwiczenie_76._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words");
            var userInput = Console.ReadLine();
            Console.WriteLine("The longest word you entered was {0} characters long", LongestWord(userInput));
        }

        public static int LongestWord(string userInput)
        {
            var path = @"C:\Users\wizmi\Desktop\udemy\c# poczatkujacy\Cwiczenie 76.2\tekst.txt";
            File.WriteAllText(path, userInput);
            var readText = File.ReadAllText(path);
            var tekst = readText.Split(' ');
            var longest = tekst[0].Length;
            foreach(var text in tekst)
            {
                if (text.Length > longest) longest = text.Length;
            }
            return longest;
        }
    }
}

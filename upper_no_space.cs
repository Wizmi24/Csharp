using System;
using System.Text;

namespace Cwiczenie_68._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words separated by space");
            var userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput)) Console.WriteLine("You entered nothing");

            var words = userInput.Split(' ');
            string answear="";

            foreach(var word in words)
            {
                answear += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }

            Console.WriteLine(answear);
        }
    }
}

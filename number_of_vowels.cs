using System;

namespace Cwiczenie_68._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            var userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You entered nothing");
                return;
            }

            int numberOfVowels = 0;

            foreach(var ch in userInput)
            {
                if(ch=='a'|| ch == 'e'|| ch == 'o'|| ch == 'u'|| ch == 'i')
                {
                    numberOfVowels++;
                }
            }

            Console.WriteLine("This word has {0} vowels", numberOfVowels);
        }
    }
}

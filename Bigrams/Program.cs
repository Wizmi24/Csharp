using System;
using System.Collections.Generic;

namespace Bigrams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*You are given an input array of bigrams, and an array of words.

            Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.*/

           var toFind = new string[]{"at", "be", "th", "au" };
           var words = new string[]{"beautiful", "the", "hat"};
 
           Console.WriteLine(FindWord.zadanie(toFind, words)?"All phrases have been found":"One or more phrases haven't been found");

            toFind = new string[] { "ay", "be", "ta", "cu" };
            words = new string[] { "maybe", "beta", "abet", "course" };

            Console.WriteLine(FindWord.zadanie(toFind, words) ? "All phrases have been found" : "One or more phrases haven't been found");

            toFind = new string[] { "th", "fo", "ma", "or" };
            words = new string[] { "the", "many", "for", "forest" };

            Console.WriteLine(FindWord.zadanie(toFind, words) ? "All phrases have been found" : "One or more phrases haven't been found");

            toFind = new string[] { "oo", "mi", "ki", "la" };
            words = new string[] { "milk", "chocolate", "cooks" };

            Console.WriteLine(FindWord.zadanie(toFind, words) ? "All phrases have been found" : "One or more phrases haven't been found");
        }
    }
}

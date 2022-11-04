using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Fibonacci
    {
        public static string zadanie(int number)
        {
            var fibonacciSequence = new List<string> { "b", "a"};

            if (number < 3)
                return "invalid";
            
            for(int i = 2; i < number; i++)
            {
                fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i-2]);
            }
            return string.Join(",", fibonacciSequence);
        }
    }
}

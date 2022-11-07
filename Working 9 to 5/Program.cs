using System;

namespace Working_9_to_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r1 = JobOverTime.zadanie(13, 21, 38.6, 1.8);
            Console.WriteLine(r1.ToString("#.##"));
        }
    }
}

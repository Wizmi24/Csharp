using System;

namespace WeekLater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Today is {DateTime.Now.ToString("d")} and week later is {DateTime.Now.AddDays(7).ToString("d")}");
        }
    }
}

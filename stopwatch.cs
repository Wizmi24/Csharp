using System;
using System.Collections.Generic;

namespace Cwiczenie_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start and stop or exit");
            var userInput = Console.ReadLine();

            if (userInput == "start")
            {
                var stopWatch = new StopWatch();
                var userInputs = new List<string>();
                while (true)
                {
                    Console.WriteLine("Enter stop, reset or exit");
                    userInputs.Add(Console.ReadLine());
                    if (userInputs[userInputs.Count-1] == "stop")
                    {
                        Console.WriteLine(stopWatch.timer(DateTime.Now));
                    }
                    else if (userInputs[userInputs.Count - 1] == "exit")
                    {
                        Console.WriteLine("ending the program");
                        return;
                    }
                    else if (userInputs[userInputs.Count - 1] == "reset")
                    {
                        stopWatch = new StopWatch();
                    }


                }
            }
            
            
        }
    }

    public class StopWatch
    {
        private DateTime _start;

        public StopWatch()
        {
            _start = DateTime.Now;
        }


        public TimeSpan timer(DateTime Stop)
        {
            return Stop - _start;
        }
    }
}

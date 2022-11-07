using System;
using System.Collections.Generic;

namespace New_Driving_License
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             You have to get a new driver's license.
             You show up at the office at the same time as four other people.
             The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license.
             All of the agents are available now, and they can each see one customer at a time.
             How long will it take for you to walk out with your new license?
             */

            string yourName, name;
            int employee;
            bool success;
            List<string> Others = new List<string>();

            do
            {
                Console.WriteLine("Enter your name");
                yourName=Console.ReadLine();
            } while (string.IsNullOrEmpty(yourName));

            do
            {
                Console.WriteLine("How many employee are working");
                var userInput = Console.ReadLine();
                success=int.TryParse(userInput, out employee);
            } while (!success||employee<1);

            do
            {
                Console.WriteLine("Enter other person name or nothing to stop");
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                    Others.Add(name);
                else break;
            } while (true);

            Console.WriteLine("You have to wait: "+PlaceInLane.zadanie(yourName, employee, Others)+" minutes");
        }
    }
}

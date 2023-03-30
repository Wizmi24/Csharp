using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLimit
{
    public class Test
    {
        public string Limit(int[] timer, int overallTime)
        {
            if (timer.Length < 8||overallTime>120)
                return "disqualified";

            var timeLimit = 0;

            for(int i = 1; i < timer.Length; i++)
            {
                if (i%2==1)
                {
                    timeLimit += 5;
                }

                Console.WriteLine("Time Limit " + timeLimit);
                Console.WriteLine("Candidate Time " + timer[i-1]);
                Console.WriteLine();

                if(timer[i-1] > timeLimit)
                {
                    return "disqualified";
                }
            }

            return "qualified";
        }
    }
}

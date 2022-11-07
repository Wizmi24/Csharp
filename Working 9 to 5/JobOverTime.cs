using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_9_to_5
{
    internal class JobOverTime
    {
        public static double zadanie(double startWork, double endWork, double hourlyRate, double overTimeMulti)
        {
            if (endWork > 17)
            {
                return (endWork - 17) * hourlyRate * overTimeMulti + (17 - startWork) * hourlyRate;
            }
            else return (endWork - startWork) * hourlyRate;
        }
    }
}

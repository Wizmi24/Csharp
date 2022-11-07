using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Driving_License
{
    public class PlaceInLane
    {
        public static int zadanie(string Name, int NumberOfEmployee, List<string> Others)
        {
            Others.Add(Name);
            Others.Sort();
            var place=Others.IndexOf(Name);
            return (place / NumberOfEmployee+1) * 20;
        }
    }
}

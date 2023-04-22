using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestLowest
{
    public class StringMath
    {
        public string HighLow(string str)
        {
            var split = str.Split(' ').Select(int.Parse);

            return new string(split.Max()+" "+split.Min());
        }
    }
}

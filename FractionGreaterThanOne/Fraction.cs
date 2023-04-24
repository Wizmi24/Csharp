using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionGreaterThanOne
{
    public class Fraction
    {
        public bool IsGreaterThanOne(string str)
        {
            var split = str.Split("/").Select(int.Parse).ToArray();
            return split[0] > split[1];
        }
    }
}

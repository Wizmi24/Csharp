using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Fractions
{
    internal class Gcd
    {
        public static int zadanie(int a, int b)
        {
            return (b == 0) ? a : zadanie(b, a % b);
        }
    }
}

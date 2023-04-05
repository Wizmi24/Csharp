using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    public class CollatzCon
    {
        public int Col(int num)
        {
            var steps = 0;

            while (num != 1)
            {
                if(num% 2 == 0)
                {
                    num /= 2;
                    steps++;
                }
                else
                {
                    num = num * 3 + 1;
                    steps++;
                }
            }
            return steps;
        }
    }
}

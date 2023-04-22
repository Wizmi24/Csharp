using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveCountNegativeSum
{
    public class ArrayMath
    {
        public int[] CountPosSumNeg(int[] arr)
        {
            int count = 0, sum = 0;
            foreach (var item in arr)
            {
                if(item > 0)
                {
                    count++;
                }
                else
                {
                    sum += item;
                }
            }

            return new[] { count, sum };
        }
    }
}

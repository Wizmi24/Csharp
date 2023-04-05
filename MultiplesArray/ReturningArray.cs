using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesArray
{
    public class ReturningArray
    {
        public int[] ArrayOfMultiples(int num, int length)
        {
            int[] array = new int[length];
            for (int i = 1; i <= length; i++)
            {
                array[i-1] = num*i;
            }
            return array;
        }
    }
}

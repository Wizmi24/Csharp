using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecitiveNumbers
{
    public class ConsNum
    {
        public bool Cons(int[] arr)
        {
            if (arr.Distinct().Count()!=arr.Length)
            {
                return false;
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]+1 != arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrime
{
    public class Prime
    {
        public int NextPrime(int num)
        {
            while (true)
            {
                if (IsPrime(num))
                {
                    return num;
                }
                num++;
            }
        }

        private bool IsPrime(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if(num% i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

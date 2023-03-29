using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumArray
{
    public class SearchForBiggestArrayNumber
    {
        public double[] FindLargest(double[][] numbers)
        {
            double[] result = new double[numbers.Length];
            var i = 0;
            foreach (var item in numbers)
            {
                result[i++] = item.Max();
            }
            return result;
        }
    }
}

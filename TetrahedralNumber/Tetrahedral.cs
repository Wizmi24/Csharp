using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrahedralNumber
{
    public class Tetrahedral
    {
        public int NthNumber(int n)
        {
            return (n * (n + 1) * (n + 2)) / 6;
        }
    }
}

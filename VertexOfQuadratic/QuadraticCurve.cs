using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexOfQuadratic
{
    public class QuadraticCurve
    {
        public double[] Vertex(int a, int b, int c)
        {
            double x = -b/(double)(2*a);
            double y = a * x * x + b * x + c;
            return new double[] { x, y };
        }
    }
}

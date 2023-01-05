using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing
{
    public class RandomGenerator
    {
        public List<int> RandomNumbers { get; private set; }
        public RandomGenerator()
        {
            RandomNumbers = new List<int>();
        }

        public List<int> Generate(int bought)
        {
            var rnd = new Random();
            for (int i = 0; i < bought; i++)
            {
                RandomNumbers.Add(rnd.Next(1, 11));
            }
            return RandomNumbers;
        }
    }
}

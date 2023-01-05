using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing
{
    public class Pack
    {
		public static void CanFit(int bags, List<int> bought)
		{
			List<int> sorted = new List<int>(bought);
			List<int> bag = new List<int>();
			int sum = 0;
			sorted.Sort();
            Console.Write("Weight of items you bought:");
			foreach (int item in sorted)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
			for(int i = 0; i < bags; i++)
            {
				bag.Clear();
				sum = 0;
				for(int j = sorted.Count-1; j >= 0; j--)
                {
					if (sum + sorted[j] < 11)
					{
						bag.Add(sorted[j]);
						sum += sorted[j];
						sorted.RemoveAt(j);
						if (sum == 10)
                        {
                            Console.Write($"Bag {i+1}:");
                            foreach (int item in bag)
                            {
                                Console.Write(" " + item);
                            }
                            Console.WriteLine();
							break;
                        }

					}
					else if(j==0)
					{
						Console.Write($"Bag {i+1}:");
						foreach (int item in bag)
						{
							Console.Write(" " + item);
						}
						Console.WriteLine();

					}
				}
            }

			if (sorted.Count == 0)
				Console.WriteLine("You packed all the items");
			else
				Console.WriteLine("You coudn't pack all the items");
		}
	}
}

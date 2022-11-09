using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Occurrance
{
    internal class MaxOccurrance
    {
        public static string zadanie(string userInput)
        {
            var groups = userInput.ToCharArray().OrderBy(x => x).GroupBy(x => x);
            var max = groups.Max(x => x.Count());
            return max > 1 ? "\""+String.Join("\", \"", groups.Where(x => x.Count() == max).Select(x=>x.Key.ToString()).ToArray())+"\"":"No repetition";

        }
    }
}

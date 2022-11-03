using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigrams
{
    public class FindWord
    {
        public static bool zadanie(string[] toFind, string[] words)
        {
            return toFind.All(b => words.Any(w => w.Contains(b)));
        }
    }
}

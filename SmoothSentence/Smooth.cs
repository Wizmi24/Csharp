using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSentence
{
    public class Smooth
    {
        public bool IsSmooth(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length-1; i++)
            {
                if (!words[i].EndsWith(words[i + 1][0]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UncensoreString
{
    public class Uncensoring
    {
        public string Uncensore(string sentence, string vowels)
        {
            char[] vow = vowels.ToCharArray();
            char[] sen = sentence.ToCharArray();

            for (int i = 0, j=0;i < sen.Length;i++)
            {
                if(sen[i] == '*')
                {
                    sen[i] = vow[j];
                    j++;
                }
            }

            return new string(sen);
        }

        public string Uncensore2(string sentence, string vowels)
        {
            var q = new Queue<char>(vowels.ToCharArray());
            return Regex.Replace(sentence, @"\*", m => q.Dequeue().ToString());
        }
    }
}

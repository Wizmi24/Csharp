using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AnagramInAtotherString
{
    public class Anagram
    {
        public bool AnagramSearch(string needle, string haystack)
        {
            char[] needleChars = needle.ToCharArray();
            var tempChars = new List<char>(needleChars);
            bool flag = true;
            for (var i = 0; i < haystack.Length ; i++)
            {
                if (flag==false)
                {
                    tempChars = new List<char>(needleChars);
                }

                flag = false;

                for (int j = 0; j < tempChars.Count; j++)
                {
                    if (haystack[i] == tempChars[j])
                    {
                        tempChars.Remove(tempChars[j]);
                        flag = true;
                        if(tempChars.Count == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

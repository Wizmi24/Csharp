using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningMiddleCharacter
{
    public class ReturnCharacter
    {
        public string MiddleChar(string str)
        {
            return (str.Length % 2 == 0) ? str.Substring(str.Length / 2 - 1, 2) : str.Substring(str.Length / 2, 1);
        }
    }
}

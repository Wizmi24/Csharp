using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterpartCharCode
{
    public class CounterPartChar
    {
        public int CharacterChar(char symbol)
        {
            return ((int)symbol)>90?(int)symbol-32:(int)symbol+32;
        }

        public int CharacterChar2(char symbol)
        {
            if (Char.IsUpper(symbol))
            {
                return (int)char.ToLower(symbol);
            }
            else
            {
                return (int)char.ToUpper(symbol);
            }
                
        }
    }
}

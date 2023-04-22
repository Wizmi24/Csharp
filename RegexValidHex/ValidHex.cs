using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexValidHex
{
    public class ValidHex
    {
        public bool RegexMethod(string check)
        {
            return Regex.IsMatch(check, @"^#[a-fA-F0-9]{6}$");
        }
    }
}

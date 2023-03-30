using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertArrToStr
{
    public class Converter
    {
        public string[] ConvertIt(object[] arr)
        {
            return Array.ConvertAll(arr, x => x.ToString());
        }
    }
}

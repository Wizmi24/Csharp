using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_39._1
{
    public class ThirdPartyMessaging : IWorkFlow
    {
        public void Execute(int Id)
        {
            Console.WriteLine("Video ready for encoding");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_39._1
{
    public class UploadingVideo : IWorkFlow
    {
        public void Execute(int Id)
        {
            Console.WriteLine("Uploading video to the service");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_39._1
{
    public class WorkFlowMachnice
    {
        private readonly IList<IWorkFlow> _workFlow;
        private readonly List<string> _videosId;

        public WorkFlowMachnice()
        {
            _workFlow = new List<IWorkFlow>();
            _videosId = new List<string>();
        }

        public void ProcessingSteps(int Id)
        {
            foreach(var step in _workFlow)
            {
                step.Execute(Id);
            }
        }

        public void AddingSteps(IWorkFlow steps)
        {
            _workFlow.Add(steps);
        }

        public int AddingVideo()
        {
            _videosId.Add("Uploading");
            return _videosId.Count - 1;
        }

        public void Processing(int Id)
        {
            _videosId[Id] = "Processing";
        }

        public void ShowAll()
        {
            foreach(var element in _videosId)
            {
                Console.WriteLine(element);
            }
        }

    }
}

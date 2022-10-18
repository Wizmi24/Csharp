using System;
using System.Collections.Generic;

namespace Cwiczenie_39._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowMachine = new WorkFlowMachnice();
            
            workFlowMachine.AddingSteps(new UploadingVideo());
            workFlowMachine.AddingSteps(new ThirdPartyMessaging());
            workFlowMachine.AddingSteps(new ProcessingVideo());
            workFlowMachine.AddingVideo();
            workFlowMachine.AddingVideo();
            workFlowMachine.AddingVideo();
            var id=workFlowMachine.AddingVideo();
            workFlowMachine.Processing(id);
            workFlowMachine.ShowAll();
            
            
            
          

        }
    }

    

    
    

    

    
}

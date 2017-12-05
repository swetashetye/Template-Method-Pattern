using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern2015
{
    public class ReturnService
    {
        public void Process (ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(returnOrder.Action);
            returnProcess.Process(returnOrder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern2015
{
   public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            throw new NotImplementedException();
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            throw new NotImplementedException();
        }
    }
}

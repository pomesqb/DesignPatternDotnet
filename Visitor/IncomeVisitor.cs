using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Console.WriteLine("IncomeVisitor " + element.GetType().Name);
        }
    }
}

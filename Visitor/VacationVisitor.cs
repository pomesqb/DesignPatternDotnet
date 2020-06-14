using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class VacationVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Console.WriteLine("VacationVisitor " + element.GetType().Name);
        }
    }
}

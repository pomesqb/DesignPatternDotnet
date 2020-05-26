using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ConcreteClass1 : AbstractClass
    {
        protected override void OperationB()
        {
            Console.WriteLine("ConcreteClass1 OperationB");
        }
    }
}

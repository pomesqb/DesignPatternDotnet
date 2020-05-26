using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ConcreteClass2 : AbstractClass
    {
        protected override void OperationB()
        {
            Console.WriteLine("ConcreteClass2 OperationB");
        }

        protected override void OperationC()
        {
            Console.WriteLine("ConcreteClass2 OperationC");
        }
    }
}

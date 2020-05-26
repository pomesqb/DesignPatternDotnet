using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            OperationA();
            OperationB();
            OperationC();
        }

        protected void OperationA()
        {
            Console.WriteLine("AbstractClass OperationA");
        }

        protected abstract void OperationB();

        protected virtual void OperationC()
        {
            Console.WriteLine("AbstractClass OperationC");
        }
    }
}

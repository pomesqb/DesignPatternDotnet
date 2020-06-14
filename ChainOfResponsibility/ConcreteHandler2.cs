using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine("ConcreteHandler2 request:" + request);

            if (next != null)
                next.HandleRequest(request);
        }
    }
}

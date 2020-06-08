using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}

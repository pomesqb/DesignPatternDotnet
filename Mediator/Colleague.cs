using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Colleague
    {
        private Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            this.mediator.Send(message, this);
        }
    }
}

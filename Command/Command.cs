using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}

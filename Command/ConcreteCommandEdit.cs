using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ConcreteCommandEdit : Command
    {
        public ConcreteCommandEdit(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}

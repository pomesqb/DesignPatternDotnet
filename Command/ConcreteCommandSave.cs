using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ConcreteCommandSave : Command
    {
        public ConcreteCommandSave(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}

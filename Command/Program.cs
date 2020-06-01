using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var command = new ConcreteCommandSave(receiver);

            var button = new Button();
            button.SetCommand(command);
            button.ExecuteCommand();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyA : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteStrategyA DoSomething");
        }
    }
}

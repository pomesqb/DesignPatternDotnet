using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyB : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteStrategyB DoSomething");
        }
    }
}

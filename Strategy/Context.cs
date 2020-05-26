using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomething()
        {
            _strategy.DoSomething();
        }
    }
}

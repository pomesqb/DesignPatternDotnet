using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomething();

            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomething();

            Console.WriteLine("Done Strategy!");
        }
    }
}

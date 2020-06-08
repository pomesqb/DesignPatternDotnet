using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var concreteColleague1 = new ConcreteColleague1(mediator);
            var concreteColleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = concreteColleague1;
            mediator.Colleague2 = concreteColleague2;

            concreteColleague1.Send("Hello");
            concreteColleague2.Send("Hi");

            Console.ReadLine();
        }
    }
}

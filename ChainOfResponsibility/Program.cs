using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handle1 = new ConcreteHandler1();
            Handler handle2 = new ConcreteHandler2();

            handle1.SetHandler(handle2);

            handle1.HandleRequest(5);

            Console.ReadLine();
        }
    }
}

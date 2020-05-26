using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteClassA = new ConcreteClass1();
            concreteClassA.TemplateMethod();

            Console.WriteLine("---------");

            var concreteClassB = new ConcreteClass2();
            concreteClassB.TemplateMethod();

            Console.WriteLine("Done TempplateMethod!");
        }
    }
}

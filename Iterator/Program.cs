using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new History();
            history.Push("against");
            history.Push("all");
            history.Push("gods");

            IIterator iterator = new ConcreteIterator(history);

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());

                iterator.Next();
            }
        }
    }
}

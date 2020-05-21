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

            for (int i = 0; i < history.GetHistoryData.Count; i++)
            {
                Console.WriteLine(history.GetHistoryData[i]);
            }
        }
    }
}

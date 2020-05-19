using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.Content = "a";
            editor.Content = "b";
            editor.Content = "c";
            editor.Content = "d";
            editor.Undo();
            editor.Undo();

            Console.WriteLine("Editor Content:" + editor.Content);
        }
    }
}

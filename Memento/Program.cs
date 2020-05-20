using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new History();

            var editor = new Editor();
            editor.Title = "title a";
            editor.Content = "content a";
            history.Push(editor.CreateMemento());

            editor.Title = "title b";
            editor.Content = "content b";

            editor.Restore(history.Pop());

            Console.WriteLine("Editor Content:" + editor.Content);
        }
    }
}

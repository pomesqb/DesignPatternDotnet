using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas(new ToolPen());
            canvas.MouseDown();
            canvas.MouseUp();

            Console.WriteLine("Done!");
        }
    }
}

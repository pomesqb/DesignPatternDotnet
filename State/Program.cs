using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.MouseDown(ToolType.SelectionTool);
            canvas.MouseUp(ToolType.Pen);

            Console.WriteLine("Done!");
        }
    }
}

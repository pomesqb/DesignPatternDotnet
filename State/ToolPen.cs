using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    /// <summary>
    /// ConcreteState
    /// </summary>
    class ToolPen : IToolState
    {
        public void MouseDown()
        {
            Console.WriteLine("pen icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("pen draw");
        }
    }
}

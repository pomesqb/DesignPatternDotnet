using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    /// <summary>
    /// ConcreteState
    /// </summary>
    class ToolEraser : IToolState
    {
        public void MouseDown()
        {
            Console.WriteLine("eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("eraser draw");
        }
    }
}

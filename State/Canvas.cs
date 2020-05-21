using System;
using System.Collections;
using System.Text;

namespace State
{
    /// <summary>
    /// Context
    /// </summary>
    class Canvas
    {
        private IToolState _toolState;

        public Canvas(IToolState toolState)
        {
            _toolState = toolState;
        }

        public void MouseDown()
        {
            _toolState.MouseDown();
        }

        public void MouseUp()
        {
            _toolState.MouseUp();
        }
    }
}

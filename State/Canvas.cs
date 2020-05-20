using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Canvas
    {
        private string _mouseIcon = "NormalIcon";

        public void MouseDown(ToolType toolType)
        {
            if(toolType == ToolType.SelectionTool)
            {
                _mouseIcon = "SelectionIcon";
            }
            else if(toolType == ToolType.Pen)
            {
                _mouseIcon = "PenIcon";

            }
            else if(toolType == ToolType.Eraser)
            {
                _mouseIcon = "EraserIcon";
            }
        }

        public void MouseUp(ToolType toolType)
        {
            if (toolType == ToolType.SelectionTool)
            {
                _mouseIcon = "SelectionIcon";
            }
            else if (toolType == ToolType.Pen)
            {
                _mouseIcon = "PenIcon";

            }
            else if (toolType == ToolType.Eraser)
            {
                _mouseIcon = "EraserIcon";
            }
        }
    }
}

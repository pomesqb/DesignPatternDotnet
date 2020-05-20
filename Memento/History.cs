using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Caretaker
    /// </summary>
    class History
    {
        private Stack<EditorState> _stack = new Stack<EditorState>();

        public void Push(EditorState editorState)
        {
            _stack.Push(editorState);
        }

        public EditorState Pop()
        {
            return _stack.Pop();
        }
    }
}

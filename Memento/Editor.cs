using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Editor
    {
        private Stack<string> _stack = new Stack<string>();

        private string _content;

        public string Content
        {
            get
            {
                return _stack.Peek();
            }
            set
            {
                _stack.Push(value);
            }
        }

        public void Undo()
        {
            _stack.Pop();
        }
    }
}

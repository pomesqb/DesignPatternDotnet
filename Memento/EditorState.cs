using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Memento
    /// </summary>
    class EditorState
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public EditorState(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}

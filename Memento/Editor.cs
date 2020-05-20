using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Originator
    /// </summary>
    class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateMemento()
        {
            var editorState = new EditorState(Title, Content);
            return editorState;
        }

        public void Restore(EditorState editorState)
        {
            Title = editorState.Title;
            Content = editorState.Content;
        }
    }
}

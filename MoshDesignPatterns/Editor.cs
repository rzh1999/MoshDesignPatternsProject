using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns
{
    class Editor
    {
        private String content;

        public string Content { get => content; set => content = value; }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState editorState)
        {
            content = editorState.Content;
        }
    }
}

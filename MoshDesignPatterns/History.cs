using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns
{
    public class History
    {
        private List<EditorState> states;

        public History()
        {
            states = new List<EditorState>();
        }

        public void Push(EditorState editorState)
        {
            states.Add(editorState);
        }

        public void Pop()
        {
            int lastIndex = states.Count - 1;
            states.RemoveAt(lastIndex);
        }
    }
}

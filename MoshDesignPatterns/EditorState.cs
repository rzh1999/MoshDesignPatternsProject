using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns
{
    public class EditorState
    {
        private string content;
        public string Content { get => content; }
       
        public EditorState(String content)
        {
            this.content = content;
        }
    }
}

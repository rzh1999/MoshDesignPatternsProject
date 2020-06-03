using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns
{
    public class MementoPattern
    {
        public void RunMemento()
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "A";
            history.Push(editor.CreateState());

            editor.Content = "B";
            history.Push(editor.CreateState());

            editor.Content = "C";
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}

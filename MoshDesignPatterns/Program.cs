using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MementoPattern mementoPattern = new MementoPattern();
            mementoPattern.RunMemento();
            Console.ReadLine();
        }
    }
}

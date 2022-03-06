using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrucStack();
            Console.ReadLine();

        }
        public static void StrucStack()
        {
            StackFirst newStack = new StackFirst();
            newStack.Push(15);
            newStack.Push(20);
            newStack.Push(25);
            newStack.Push(35);
            newStack.StacIn();
            newStack.Peek();
            newStack.Pop();
            newStack.Peek();
            newStack.StacIn();
        }
    }
}

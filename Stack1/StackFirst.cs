using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucStack
{
    internal class StackFirst
    {


        static readonly int MAX = 1000;
        int top;
        int[] v = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public StackFirst()
        {
            top = -1;
        }
        internal void Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                v[++top] = data;
            }
            Console.WriteLine("{0} pushed to stack", data);
        }

        internal void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Item popped is {0}", v);
                top--;
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("{0} is on the top of Stack", v[top]);
        }
        internal void StacIn()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
    }
}

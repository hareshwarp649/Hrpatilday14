using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucStack1
{
    internal class NodeStack
    {

        internal int data;
        internal NodeStack next;


        public NodeStack(int d)
        {
            data = d;
            next = null;
        }
    }
}
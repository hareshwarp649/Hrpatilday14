using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSecond
{
    internal class NodeQueue
    {
        internal int data;
        internal NodeQueue next;


        public NodeQueue(int d)
        {
            data = d;
            next = null;
        }
    }
}
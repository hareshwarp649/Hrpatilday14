using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueTake();
            Console.ReadLine();
        }
        public static void QueueTake()
        {
            QueueSec sec = new QueueSec();
            sec.Enqueue(52);
            sec.Enqueue(62);
            sec.Enqueue(85);
            sec.Enqueue(89);
            sec.PrintQueue();

            
            sec.Dequeue();
            
            sec.Enqueue(89);
            sec.PrintQueue();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueRef();
            Console.ReadLine();
        }

        public static void QueueRef()
        {
            Queuefirst fir = new Queuefirst(100);
            QueueSer ser = new QueueSer();

            ser.EnQueue(fir, 18);
            ser.EnQueue(fir, 19);
            ser.EnQueue(fir, 48);
            ser.EnQueue(fir, 56);

            ser.FrontElement(fir);
            ser.RearElement(fir);

            ser.PrintQueue(fir);

            ser.DeQueue(fir);

            ser.FrontElement(fir);
            ser.RearElement(fir);
            ser.PrintQueue(fir);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructQueue
{
    internal class Queuefirst
    {
        
        internal int front;
        internal int rear;
        internal int size;

        internal int capacity;

        internal int[] array;

        public Queuefirst(int capacity)
        {
            this.capacity = capacity;
            front = this.size = 0;
            rear = capacity - 1;
            array = new int[capacity];
        }
    }

    internal class QueueSer
    {
        internal bool IsFull(Queuefirst queue)
        {
            return (queue.size == queue.capacity);
        }

       
        internal bool IsEmpty(Queuefirst queue)
        {
            return (queue.size == 0);
        }

       
        internal void EnQueue(Queuefirst queue, int item)
        {
            if (IsFull(queue))
            {
                return;
            }
            queue.rear = (queue.rear + 1) % queue.capacity;
            queue.array[queue.rear] = item;
            queue.size = queue.size + 1;
            Console.WriteLine("Value {0} has been Enqueued", item);
        }

       
        internal void DeQueue(Queuefirst queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            int item = queue.array[queue.front];
            queue.front = (queue.front + 1) % queue.capacity;
            queue.size = queue.size - 1;
            Console.WriteLine("Item deleted is {0}", item);
        }

        
        internal void FrontElement(Queuefirst queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Console.WriteLine("Front : {0}", queue.array[queue.front]);
        }

      
        internal void RearElement(Queuefirst queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Console.WriteLine("Rear : {0}", queue.array[queue.rear]);
        }

        internal void PrintQueue(Queuefirst queue)
        {
            for (int i = queue.front; i <= queue.rear; i++)
            {
                Console.Write(queue.array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

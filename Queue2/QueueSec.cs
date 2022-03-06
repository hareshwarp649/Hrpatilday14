using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSecond
{
    internal class QueueSec
    {
        NodeQueue front;
        NodeQueue rear;

        public QueueSec()
        {
            this.front = this.rear = null;
        }

       
        internal void Enqueue(int item)
        {
            NodeQueue newNode = new NodeQueue(item);

            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }

        
        internal void Dequeue()
        {
           
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            
            NodeQueue temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

       
        internal void PrintQueue()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            NodeQueue temp = this.front;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}

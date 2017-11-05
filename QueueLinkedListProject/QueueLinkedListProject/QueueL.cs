using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedListProject
{
    class QueueL
    {
        private Node front;
        private Node rear;

        public QueueL()
        {
            front = null;
            rear = null;
        }

        public bool isEmpty()
        {
            return (front == null);
        }
        public int Size()
        {
            int s = 0;
            Node p = front;
            while(p != null)
            {
                s++;
                p = p.link;
            }
            return s;
        }

        public void Insert(int x)
        {
            Node temp;
            temp = new Node(x);

            if (front == null)
                front = temp;
            else
                rear.link = temp;
            rear = temp; 
        }

        public int Delete()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            x = front.info;
            front = front.link;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return front.info;
        }

        public void Display()
        {
            Node p = front;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            Console.WriteLine("Queue is ");
            while(p!= null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}

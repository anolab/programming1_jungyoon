using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueProject
{
    class CircularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public CircularQueue()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        public bool isFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1)) || ((front == rear + 1));
        }

        public void Insert(int x)
        {
            if(isFull())
            {
                Console.WriteLine("Queue Overflow\n");
                return;
            }
            if (front == -1)
                front = 0;
            if (rear == queueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            queueArray[rear] = x;
        }

        public int Delete()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");

            int x = queueArray[front];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public void Display()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Queue is : ");

            int i = front;
            if (front <= rear)
            {
                while (i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }
            else
            {
                while (i <= queueArray.Length - 1)
                    Console.WriteLine(queueArray[i++] + " ");
                i = 0;
                while (i <= rear)
                    Console.WriteLine(queueArray[i++] + " ");
            }
        }
    }
}

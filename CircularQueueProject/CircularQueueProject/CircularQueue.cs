using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueProject
{
    class CircularQueue
    {
        int[] cqueue;
        int front;
        int end;

        public CircularQueue()
        {
            cqueue = new int[5];
            front = -1;
            end = -1;
        }

        public CircularQueue(int num)
        {
            cqueue = new int[10];
            front = -1;
            end = -1;
        }

        /* 1. 원소 입력 */
        public void Enqueue(int num)
        {
            /* 처음에 들어 옴 */
            if (CheckEmpty())
            {
                cqueue[0] = num;
                front = 0;
                end = 0;
            }

            /* 처음 이후 들어 옴 */
            else
            {
                if (CheckFull())
                    Console.WriteLine("Full");
                else
                {
                    if (end == cqueue.Length -1)
                    {
                        end = 0;
                        cqueue[end] = num;
                    }
                    else
                    {
                        end = end + 1;
                        cqueue[end] = num;
                    }
                }
            }

        }

        // Empty Check
        public bool CheckFull()
        {
            if(front == 0 && end == cqueue.Length-1)
            {
                return true;
            }
            if(front == end + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Full Check
        public bool CheckEmpty()
        {
            if(front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* 2. 원소 삭제 */
        public void Dequeue()
        {
            if (CheckEmpty())
                Console.WriteLine("Emtpy");
            
            else
            {
                if (front == end)
                {
                    int value = cqueue[front];
                    Console.WriteLine(value);
                    front = -1;
                    end = -1;
                }
                else
                {

                    if (front == cqueue.Length - 1)
                    {
                        int value = cqueue[front];
                        front = 0;
                        Console.WriteLine(value);
                    }
                    else
                    {
                        int value = cqueue[front];
                        front = front + 1;
                        Console.WriteLine(value);
                    }
                }
            }
        }

        /* 3. Display */
        public void Display()
        {
            if (CheckEmpty())
                return;

            if (front <= end)
            {
                for (int i = front; i <= end; i++)
                {
                    Console.Write(cqueue[i]);
                }
            }
            else
            {
                for (int i = front; i <= cqueue.Length - 1; i++)
                {
                    Console.Write(cqueue[i]);
                }
                for (int i = 0; i <= end; i++)
                {
                    Console.Write(cqueue[i]);
                }
            }
        }
    }
}

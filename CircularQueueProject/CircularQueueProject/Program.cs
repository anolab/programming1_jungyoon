using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data;
            CircularQueue cqueue = new CircularQueue();

            while (true)
            {

                Console.Write("\n1. Display list");
                Console.Write("\n2. Insert");
                Console.Write("\n3. Delete");

                Console.Write("\n번호 입력: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cqueue.Display();
                        break;

                    case 2:
                        Console.Write("숫자 입력: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        cqueue.Enqueue(data);
                        break;

                    case 3:
                        cqueue.Dequeue();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}

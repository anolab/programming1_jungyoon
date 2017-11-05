using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            QueueL ql = new QueueL();

            while (true)
            {
                Console.WriteLine("1. Push an element on the queue");
                Console.WriteLine("2. Pop an element from the queue");
                Console.WriteLine("3. Display the top elements");
                Console.WriteLine("4. Display all queue members");
                Console.WriteLine("5. Display size of the queue");
                Console.WriteLine("6. Quit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enther the element to be pushed: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        ql.Insert(x);
                        break;

                    case 2:
                        x = ql.Delete();
                        Console.WriteLine("Popped element is " + x);
                        break;

                    case 3:
                        Console.WriteLine("Element at the front is " + ql.Peek());
                        break;

                    case 4:
                        ql.Display();
                        break;

                    case 5:
                        Console.WriteLine("Size of stack " + ql.Size());
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
            Console.WriteLine("Exit");
        }
    }
}

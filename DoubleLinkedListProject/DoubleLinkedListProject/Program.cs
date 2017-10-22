using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            DoubleLinkedList list = new DoubleLinkedList();
            list.CreateList();

            while (true)
            {

                Console.WriteLine("\n1. Display list");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert in the beggining of the linkedlist.");
                Console.WriteLine("4. Insert a node at the end of the list");
                Console.WriteLine("5. Insert a node after a specified node");
                Console.WriteLine("6. Insert a node before a specified node");
                Console.WriteLine("7. Delete first node");
                Console.WriteLine("8. Delete last node");
                Console.WriteLine("9. Delete any node");
                Console.WriteLine("10. Reverse the list");
                Console.WriteLine("11. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;

                    case 2:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;

                    case 3:
                        Console.Write("Enter the element to be insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeggining(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;

                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;

                    case 6:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;

                    case 7:
                        list.DeleteFirstNode();
                        break;

                    case 8:
                        list.DeleteLastNode();
                        break;

                    case 9:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    case 10:
                       list.ReverseList();
                        break;

                    case 11:
                        Console.Write("Exit");
                        break;
                        
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}

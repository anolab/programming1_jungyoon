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
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list/Insert in the beggining of the linkedlist.");
                Console.WriteLine("5. Insert a noode at the end of the list");
                Console.WriteLine("6. Insert a node after a specified node");

                Console.WriteLine("7. Insert a node before a specified node");
                Console.WriteLine("8. Insert a node at a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list");

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
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    case 10:
                        list.ReverseList();
                        break;

                    default:
                        Console.WriteLine("Wrong Chocie");
                        break;
                }
            }
        }
    }
}

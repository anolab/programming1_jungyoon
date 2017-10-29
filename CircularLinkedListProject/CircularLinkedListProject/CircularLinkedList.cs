using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        // 0. create a new linkedList 
        public void CreateList()
        {
            int n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the elemented to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    InsertInEmptyList(data);
                }
                else
                {
                    InsertAtEnd(data);
                }
            }
        }

        // 1. display
        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty.\n");
                return;
            }

            Node p = last;
            do
            {
                p = p.link;
                Console.WriteLine(p.info + " ");
            } while (p.link != last.link);

            Console.WriteLine();
        }

        // 2. insert in empty list
        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            temp.link = temp;

        }

        // 3. insert in the beginning
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

       // 4. insert at the end
       public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
 
        }

       // 5. insert after a node
       public void InsertAfter(int data, int x)
        {
            Node p = last.link;
            do
            {
                if (p.info == x)
                    break;
                p = p.link;
            } while (p != last.link);

            if (p == last.link && p.info != x)
                Console.WriteLine(x + " not present in the list.");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;
            }

        }

    }
}
 
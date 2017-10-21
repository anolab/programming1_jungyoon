using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        // start node
        private Node start;

        // Constructor 
        public SingleLinkedList()
        {
            start = null;
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
                InsertAtEnd(data);
            }
            
        }
        
        // 1. display a linkedlist
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                p = start;

                // repeat until p points to null
                while(p != null)
                {
                    Console.WriteLine(p.info);
                    p = p.link;
                }
            }
        }

        // 2. count nodes in a linkedlist
        public void CountNodes()
        {
            Node p;
            int size = 0;

            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                p = start;

                // repeat until p points to null
                while (p != null)
                {
                    p = p.link;
                    size++;
                }
                Console.WriteLine("Total Nodes of a LinkedList: " + size);
            }
        }

        // 3. search a node in a linkedlist
        public void Search(int data)
        {
            Node p = start;
            int position = 1;

            while(p != null)
            {
                if (p.info == data)
                    break;

                p = p.link;
                position++;
            }
            if(p == null)
            {
                Console.WriteLine("There is no " + data + " in the linkedlist");
            }
            else
            {
                // position of start is 0
                Console.WriteLine(data + " is in the position " + position);
            }
        }

        // 4. Insert a node in the front of the linkedlist.
        public void InsertAtBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        // 5. Insert a node in the end of the linkedlist.
        public void InsertAtEnd(int data)
        {
            Node p; // p is null
            Node temp = new Node(data); // temp is a node(info = i, link = null)

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;

            // if p is the last node
            while (p.link != null)
            {
                // traverse
                p = p.link;
            }

            // now temp is inserted at the end of linkedlist.
            p.link = temp;

        }

        // 6 Insert a node after the specified node.
        public void InsertAfter(int data, int x)
        {
            // Empty Check
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node p; // p is null
            p = start;

            // if list is not empty
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " is not in the list.");
            else
            {
                Node temp = new Node(data); // temp is a node(info = i, link = null)
                temp.link = p.link;
                p.link = temp;
            }
        }

        // 7. Insert a node before the specified node.
        public void InsertBefore(int data, int x)
        {
            // Empty Check
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if there is only one element
            if (x == start.info)
            {
                Node temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p;
            p = start;

            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if(p.link == null)
            {
                Console.WriteLine(x + " is not in the list.");
            }
            else
            {
                Node temp = new Node(data); // temp is a node(info = i, link = null)
                temp.link = p.link;
                p.link = temp;
            }
        }

        // 8. Insert a node at a specific position.
        public void InsertAtPosition(int data, int position)
        {
            Node temp;
            int i, last = 1;

            if(position == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;

            //beuatiful logic
            for (i = 1; i < position-1 && p != null; i++)
            {
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine("You can insert only upto " + i + "th position");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }
    }
}

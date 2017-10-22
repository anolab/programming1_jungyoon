﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class DoubleLinkedList
    {
        private Node start;

        public DoubleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            p = start;
            Console.Write("List is: ");
            while(p!= null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }

        public void InsertInBeggining(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            Node p = start;

            while (p.next != null)
            {
                p = p.next;
            }

            p.next = temp;
            temp.prev = p;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            Console.Write("Enter the first element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the next element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            if (checkEmptyList() == false)
                return;

            Node p = start;

            while(p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " not in the list.");

            else
            {
                Node temp = new Node(data);
                temp.prev = p;
                temp.next = p.next;

                // if p is not last node
                if (p.next != null)
                {
                    p.next.prev = temp;
                }
                p.next = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            if (checkEmptyList() == false)
                return;
            
            if (start.info == x)
            {
                Node temp = new Node(data);
                temp.next = start;
                start.prev = temp;
                start = temp;
                return;
            }

            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.Write(x + " is not in the list");
            else
            {
                Node temp = new Node(data);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }

        public void DeleteFirstNode()
        {
            // if list is empty
            if (start == null)
                return;

            // if list has only one node
            if (start.next == null)
            {
                start = null;
                return;
            }

            start = start.next;
            start.prev = null;
        }

        public void DeleteLastNode()
        {
            // if list is empty
            if (start == null)
                return;

            // if list has one node
            if (start.next == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.next != null)
                p = p.next;
            p.prev.next = null;
        }

        public void DeleteNode(int x)
        {
            // list is empty
            if (start == null)
                return;
            // list has only one node
            if(start.next == null)
            {
                if (start.info == x)
                    start = null;
                else
                    Console.WriteLine(x + " not found");
                return;
            }
            //Deletion of first node
            if(start.info == x)
            {
                start = start.next;
                start.prev = null;
                return;
            }

            Node p = start.next;
            while(p.next != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            //Between the nodes
            if(p.next != null)
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
            //Deletion of last node
            else
            {
                if (p.info == x)
                    p.prev.next = null;
                else
                    Console.WriteLine(x + "is not found");
            }
        }

        public void ReverseList()
        {
            if (start == null)
                return;

            Node p1 = start;
            Node p2 = p1.next;
            p1.next = null;
            p1.prev = p2;

            while(p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            start = p1;
        }

        public bool checkEmptyList()
        {
            if(start == null)
            {
                Console.Write("List is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

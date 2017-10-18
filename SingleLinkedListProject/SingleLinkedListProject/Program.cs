using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            // SingleLinkedList 인스턴스 생성
            SingleLinkedList list = new SingleLinkedList();
            
            // LinkedList 생성
            list.CreateList();

            while (true)
            {


                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list/Insert in the beggining of the linkedlist.");
                Console.WriteLine("5. Insert a noode at the end of the list");

                Console.Write("Please input a number: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // 1. LinkedList에 있는 데이터 출력
                    case 1:
                        list.DisplayList();
                        break;

                    // 2. LinkedList에 있는 노드 개수 출력
                    case 2:
                        list.CountNodes();
                        break;

                    // 3. LinkedList에서 입력 데이터 탐색
                    case 3:
                        Console.Write("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;

                    // 4. LinkedList 처음 부분에 입력
                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        break;

                    // 5. LinkedList 마지막 부분에 입력
                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break; 
                }

            }

        }
    }
}
 
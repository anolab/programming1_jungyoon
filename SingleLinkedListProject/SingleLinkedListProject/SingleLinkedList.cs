using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        // 시작 노드
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {

        }
        
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
        }
    }
}

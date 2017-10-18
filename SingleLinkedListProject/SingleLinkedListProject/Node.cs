using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Node
    {
        public int info;    // This Node가 보유한 information
        public Node link;   // Next Node를 가리키는 Reference

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}

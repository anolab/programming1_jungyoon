using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Node
    {
        public int info;    // info is inforamtion of this node.
        public Node link;   // link refers to next node.

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}

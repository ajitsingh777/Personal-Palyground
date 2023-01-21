using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree
{
    internal class Node
    {
        public int key;
        public Node left;
        public Node right;
        public Node(int data)
        {
            key = data;
        }
    }
}

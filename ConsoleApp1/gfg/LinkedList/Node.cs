using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
        }
    }

    public class DoublyNode
    {
        public int data;
        public DoublyNode? next;
        public DoublyNode? prev;
        public DoublyNode(int value)
        {
            data = value;
        }
    }

    public class NodeWithRandom
    {
        public int data;
        public NodeWithRandom next;
        public NodeWithRandom random;
        public NodeWithRandom(int value)
        {
            data = value;
        }
    }
}

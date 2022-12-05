using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class ReverseLinkedList
    {
        public Node Reverse(Node head)
        {
            Node prev = null, curr = head;
            while (curr != null)
            {
                Node temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }
    }
}

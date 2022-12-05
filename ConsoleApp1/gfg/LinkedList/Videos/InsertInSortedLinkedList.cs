using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class InsertInSortedLinkedList
    {
        public Node Insert(Node head, int value)
        {
            Node tmp = new Node(value);
            if (head == null)
            {
                return tmp;
            }
            Node curr = head;
            if (value < curr.data)
            {
                tmp.next = curr;
                return tmp;
            }
            while (curr.next != null && curr.next.data < value)
            {
                curr = curr.next;
            }
            tmp.next = curr.next;
            curr.next = tmp;
            return head;
        }
    }
}

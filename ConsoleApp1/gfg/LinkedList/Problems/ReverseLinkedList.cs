using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/reverse-a-linked-list
    /// </summary>
    internal class ReverseLinkedList
    {
        public Node reverseList(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            Node prev = null;
            Node curr = head;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}

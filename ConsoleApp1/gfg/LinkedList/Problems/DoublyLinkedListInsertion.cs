using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/insert-a-node-in-doubly-linked-list
    /// </summary>
    internal class DoublyLinkedListInsertion
    {
        public void addNode(DoublyNode head, int pos, int data)
        {
            DoublyNode curr = head;
            while (curr != null && pos > 0)
            {
                curr = curr.next;
                pos--;
            }
            if (pos > 0)
            {
                return;
            }
            DoublyNode tmp = new DoublyNode(data);
            if (curr.next == null)
            {
                curr.next = tmp;
                tmp.prev = curr;
            }
            else
            {
                tmp.next = curr.next;
                curr.next.prev = tmp;
                curr.next = tmp;
                tmp.prev = curr;
            }
        }
    }
}

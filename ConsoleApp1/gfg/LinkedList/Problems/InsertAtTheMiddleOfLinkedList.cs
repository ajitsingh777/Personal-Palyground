using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class InsertAtTheMiddleOfLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/insert-in-middle-of-linked-list
        /// </summary>
        /// <param name="head"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public Node insertInMiddle(Node head, int x)
        {
            Node tmp = new Node(x);
            if (head == null)
            {
                return tmp;
            }
            Node slow = head;
            Node fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            tmp.next = slow.next;
            slow.next = tmp;
            return head;
        }
    }
}

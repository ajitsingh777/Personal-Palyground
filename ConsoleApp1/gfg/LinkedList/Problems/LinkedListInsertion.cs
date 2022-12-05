using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    ///https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/linked-list-insertion-1587115620
    internal class LinkedListInsertion
    {
        public Node insertAtBeginning(Node head, int x)
        {
            Node tmp = new Node(x);
            tmp.next = head;
            return tmp;
        }

        public Node insertAtEnd(Node head, int x)
        {
            Node tmp = new Node(x);
            if (head == null)
            {
                return tmp;
            }
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = tmp;
            return head;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class PairwiseSwapOfNodes
    {
        public Node pairwise_swap(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            Node curr = head;
            Node prev = curr;
            Node newHead = curr.next;
            while (curr != null && curr.next != null)
            {
                Node next = curr.next.next;
                curr.next.next = curr;
                prev.next = curr.next;
                curr.next = next;
                prev = curr;
                curr = next;
            }
            return newHead;
        }
    }
}

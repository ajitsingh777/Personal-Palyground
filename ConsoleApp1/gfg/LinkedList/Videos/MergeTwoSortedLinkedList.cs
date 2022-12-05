using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class MergeTwoSortedLinkedList
    {
        public Node Merge(Node head1, Node head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            if (head2 == null)
            {
                return head1;
            }
            Node curr1, curr2;

            if (head1.data <= head2.data)
            {
                curr1 = head1;
                curr2 = head2;
            }
            else
            {
                curr1 = head2;
                curr2 = head1;
            }
            Node prev = curr1;
            Node newHead = curr1;
            curr1 = curr1.next;
            while (curr1 != null && curr2 != null)
            {
                if (curr1.data <= curr2.data)
                {
                    prev.next = curr1;
                    curr1 = curr1.next;
                }
                else
                {
                    prev.next = curr2;
                    curr2 = curr2.next;
                }
                prev = prev.next;
            }
            if (curr1 != null)
            {
                prev.next = curr1;
            }
            if (curr2 != null)
            {
                prev.next = curr2;
            }
            return newHead;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class RemoveLoopFromLinkedList
    {
        public void DetectAndRemoveLoopfromLinkedList(Node head)
        {
            if (head == null) return;
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) break;
            }
            if (slow != fast)
            {
                return;
            }
            slow = head;
            while (slow.next != fast.next)
            {
                slow = slow.next;
                fast = fast.next;
            }
            fast.next = null;
        }
    }
}

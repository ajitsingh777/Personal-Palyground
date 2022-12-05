using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class DetectLoopInLinkedList
    {
        public bool DetectLoop(Node head)
        {
            if (head != null)
            {
                Node slow = head;
                Node fast = head;
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                    if (slow == fast)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void DetectAndRemoveLoop(Node head)
        {
            if (head == null)
            {
                return;
            }
            Node slow = head;
            Node fast = head;
            ///detect first meeting point of slow and fast in cycle
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    break;
                }
            }
            ///check if slow and fast are not meeting i.e. no loop in linkedList
            if (slow != fast)
            {
                return;
            }
            slow = head;
            /// now slow and fast will meet at entry point of loop
            while (slow.next != fast.next)
            {
                slow = slow.next;
                fast = fast.next;
            }

            /// that condition occur when last node is firming loop with head ie full LinkedList as cycle
            if (slow == fast)
            {
                while (fast.next != head)

                {
                    fast = fast.next;
                }
            }
            fast.next = null;

        }
    }
}

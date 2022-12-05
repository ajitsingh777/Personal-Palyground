using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/detect-loop-in-linked-list
    /// </summary>
    internal class DetectLoopInLinkedList
    {

        public bool detectLoop(Node head)
        {
            if (head == null || head.next == null) return false;
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
            return false;
        }
    }
}

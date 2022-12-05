using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/find-length-of-loop
    /// </summary>
    internal class FindLengthOfLoop
    {
        public int countNodesinLoop(Node head)
        {
            if (head == null || head.next == null) return 0;
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    break;
                }
            }
            if (slow != fast)
            {
                return 0;
            }
            int count = 0;
            do
            {
                count++;
                fast = fast.next;
            } while (fast != slow);
            return count;
        }
    }
}

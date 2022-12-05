using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/MTQ2OA%3D%3D
    /// </summary>
    internal class ReverseLinkedListInGroups
    {
        public Node Reverse(Node head, int k)
        {
            Node prev = null, next = null, curr = head;
            int count = 0;
            while (curr != null && count < k)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                count++;
            }
            if (next != null)
            {
                Node rest_head = Reverse(next, k);
                head.next = rest_head;
            }
            return prev;
        }
    }
}

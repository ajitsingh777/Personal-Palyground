using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class IntersectionOfTwoLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NjM0
        /// TC - O(m+n), SC - O(m)
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        public int Intersection_Approach1(Node head1, Node head2)
        {
            HashSet<Node> nodes = new HashSet<Node>();
            Node curr = head1;
            while (curr != null)
            {
                nodes.Add(curr);
                curr = curr.next;
            }
            curr = head2;
            while (curr != null)
            {
                if (nodes.Contains(curr))
                {
                    return curr.data;
                }
                curr = curr.next;
            }
            return -1;
        }

        /// <summary>
        /// count nodes in both linked list and find the absolute difference
        /// move bigger linkedList by difference and than move both LL together they will meet at intersection point
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        public int Intersection_Approach2(Node head1, Node head2)
        {
            int count1 = 0, count2 = 0;
            Node curr = head1;
            while (curr != null)
            {
                count1++;
                curr = curr.next;
            }
            curr = head2;

            while (curr != null)
            {
                count2++;
                curr = curr.next;
            }
            int absDiff = Math.Abs(count1 - count2);
            Node curr2;
            if (count1 > count2)
            {
                curr = head1;
                curr2 = head2;
                for (int i = 0; i < absDiff; i++)
                {
                    curr = curr.next;
                }
            }
            else
            {
                curr = head2;
                curr2 = head1;
                for (int i = 0; i < absDiff; i++)
                {
                    curr = curr.next;
                }
            }
            while (curr != null && curr2 != null)
            {
                if (curr == curr2)
                {
                    return curr.data;
                }
                curr = curr.next;
                curr2 = curr2.next;
            }

            return -1;

        }
    }
}

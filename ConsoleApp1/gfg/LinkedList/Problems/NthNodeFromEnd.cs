using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class NthNodeFromEnd
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/nth-node-from-end-of-linked-list
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int getNthFromLast(Node head, int k)
        {
            Node first = head;
            Node second = head;
            for (int i = 0; i < k; i++)
            {
                if (first == null)
                {
                    return -1;
                }
                first = first.next;
            }
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            return second.data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class CountNodesInLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/count-nodes-of-linked-list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int getCount(Node head)
        {
            int count = 0;
            Node curr = head;
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }
            return count;
        }
    }
}

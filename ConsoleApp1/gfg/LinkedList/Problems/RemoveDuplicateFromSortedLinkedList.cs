using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class RemoveDuplicateFromSortedLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/remove-duplicate-element-from-sorted-linked-list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node removeDuplicates(Node head)
        {
            Node curr = head;
            while(curr != null) {
                Node nextNode = curr.next;
                while(nextNode != null && nextNode.data == curr.data)
                {
                    nextNode = nextNode.next;
                }
                curr.next = nextNode;
                curr = curr.next;
            }

            return head;
        }
    }
}

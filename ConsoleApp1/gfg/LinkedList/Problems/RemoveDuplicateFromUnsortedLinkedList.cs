using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/remove-duplicates-from-an-unsorted-linked-list
    /// </summary>
    internal class RemoveDuplicateFromUnsortedLinkedList
    {
        public Node removeDuplicates(Node head)
        {
            HashSet<int> exist = new HashSet<int>();
            Node curr = head;
            exist.Add(curr.data);
            while (curr.next != null)
            {
                if (exist.Contains(curr.next.data))
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    exist.Add(curr.next.data);
                    curr = curr.next;
                }
            }
            return head;
        }
    }
}

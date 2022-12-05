using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/identical-linked-lists
    /// </summary>
    internal class IdenticalLinkedList
    {
        public bool isIdentical(Node head1, Node head2)
        {
            Node curr1 = head1;
            Node curr2 = head2;
            while (curr1 != null && curr2 != null)
            {
                if (curr1.data != curr2.data)
                {
                    return false;
                }
                curr1 = curr1.next;
                curr2 = curr2.next;
            }
            if (curr1 != null || curr2 != null)
            {
                return false;
            }
            return true;
        }
    }
}

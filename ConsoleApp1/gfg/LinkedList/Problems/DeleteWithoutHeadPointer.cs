using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/problem/delete-without-head-pointer
    /// </summary>
    internal class DeleteWithoutHeadPointer
    {
        public void deleteNode(Node del)
        {
            del.data = del.next.data;
            del.next = del.next.next;
        }
    }
}

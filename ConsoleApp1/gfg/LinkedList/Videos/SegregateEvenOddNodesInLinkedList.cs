using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class SegregateEvenOddNodesInLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NzAyNw%3D%3D
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node SegregateNodes(Node head)
        {
            ///es=even start, ee=event end, os = odd start, oe=odd end
            Node es = null, ee = null, os = null, oe = null;
            Node curr = head;
            while (curr != null)
            {
                int x = curr.data;
                if (x % 2 == 0)
                {
                    if (es == null)
                    {
                        es = ee = curr;
                    }
                    else
                    {
                        ee.next = curr;
                        ee = ee.next;
                    }
                }
                else
                {
                    if (os == null)
                    {
                        os = oe = curr;
                    }
                    else
                    {
                        oe.next = curr;
                        oe = oe.next;
                    }
                }
                curr = curr.next;
            }
            if (es == null || os == null)
            {
                return head;
            }
            ee.next = os;
            oe.next = null;
            return es;
        }
    }
}

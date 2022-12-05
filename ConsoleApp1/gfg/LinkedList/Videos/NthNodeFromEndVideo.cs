using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class NthNodeFromEndVideo
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/Nzk2Nw%3D%3D
        /// </summary>
        /// <param name="head"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public int NthNodeFromEnd(Node head, int position)
        {
            if (head == null) return -1;
            Node first = head;
            Node second = head;
            int i = 0;
            while (i < position)
            {
                //if first become null means that position is not in linkedlist
                if (first == null) return -1;
                first = first.next;
                i++;
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

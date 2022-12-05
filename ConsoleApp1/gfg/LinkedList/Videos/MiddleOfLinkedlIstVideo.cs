using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class MiddleOfLinkedlIstVideo
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NjI1
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int MiddleOfLinkedList(Node head)
        {
            if (head == null)
            {
                return -1;
            }
            Node slow = head;
            Node fast = head;
            while (fast != null || fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
        }
    }
}

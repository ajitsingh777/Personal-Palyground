using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class RemoveDuplicateFromSortedLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/MTQ0MA%3D%3D
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public void RemoveDuplicate(Node head)
        {
            Node curr = head;
            while (curr != null)
            {
                Node nextNode = curr.next;
                while (nextNode != null && nextNode.data == curr.data)
                {
                    nextNode = nextNode.next;
                }
                curr.next = nextNode;
                curr = curr.next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class DeleteRandomNodeInLinkedList
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NjMy
        /// copy data of next node to current node and then delete next node
        /// </summary>
        /// <param name="random"></param>
        public void DeleteRandom(Node random)
        {
            random.data = random.next.data;
            random.next = random.next.next;
        }
    }
}

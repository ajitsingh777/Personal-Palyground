using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class CloneLinkedListWithRandomPointer
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NzAzMQ%3D%3D
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public NodeWithRandom clone_approach1(NodeWithRandom head)
        {
            Dictionary<NodeWithRandom, NodeWithRandom> map = new Dictionary<NodeWithRandom, NodeWithRandom>();
            NodeWithRandom curr = head;
            while (curr != null)
            {
                map.Add(curr, new NodeWithRandom(curr.data));
                curr = curr.next;
            }
            curr = head;
            while (curr != null)
            {
                NodeWithRandom clone = map[curr];
                clone.next = map[curr.next];
                clone.random = map[curr.random];
                curr = curr.next;
            }
            return map[head];
        }

        public NodeWithRandom clone_approach2(NodeWithRandom head)
        {
            NodeWithRandom curr = head;
            while (curr != null)
            {
                NodeWithRandom clone1 = new NodeWithRandom(curr.data);
                clone1.next = curr.next;
                curr.next = clone1;
                curr = curr.next.next;
            }
            curr = head;
            while (curr != null)
            {
                curr.next.random = curr.random == null ? null : curr.random.next;
                curr = curr.next.next;
            }
            NodeWithRandom h2 = head.next;
            NodeWithRandom clone = h2;
            curr = head;
            while (curr != null)
            {
                curr.next = curr.next.next;
                clone.next = clone.next != null ? clone.next.next : null;
                clone = clone.next;
                curr = curr.next;
            }
            return h2;
        }
    }
}

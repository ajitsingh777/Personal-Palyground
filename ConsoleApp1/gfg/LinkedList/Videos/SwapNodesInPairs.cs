using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class SwapNodesInPairs
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-LinkedList/video/NzAyOQ%3D%3D
        /// </summary>
        /// <param name="head"></param>
        public void SwapInPairs_Approach1(Node head)
        {
            Node curr = head;
            while (curr != null && curr.next != null)
            {
                int temp = curr.data;
                curr.data = curr.next.data;
                curr.next.data = temp;
                curr = curr.next.next;
            }
        }

        public Node SwapPairs_Appraoch2(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            /// store 3rd node
            Node curr = head.next.next;
            /// first node will be previous post swap
            Node prev = head;
            /// make second node as head
            head = head.next;
            /// set first node as next of head (20->10)
            /// LL at this time is 20->10  30->40->50->60->null
            /// no link between 10 and 30 yet
            head.next = prev;
            while (curr != null && curr.next != null)
            {
                /// node next node to pairs for next cycle i.e 50 here
                Node nextNode = curr.next.next;

                /// reverse link in current pair
                /// 30->40 to 40->30
                curr.next.next = curr;

                /// create link between last pair and current pair 20->10->40->30
                prev.next = curr.next;

                /// 30 will be previous in next cycly
                prev = curr;
                /// 50 will be current here
                curr = nextNode;
            }
            /// add last node of linkedlist 
            /// in even linked list it will be null and in odd LL it will be last node
            prev.next = curr;
            return head;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class IntersectionPointOfTwoLinkedList
    {
        public int intersectPoint(Node head1, Node head2)
        {
            int count1 = 0, count2 = 0;
            Node curr1 = head1, curr2 = head2;
            while (curr1 != null)
            {
                count1++;
                curr1 = curr1.next;
            }
            while (curr2 != null)
            {
                count2++;
                curr2 = curr2.next;
            }
            int abs = Math.Abs(count1 - count2);
            curr1 = head1;
            curr2 = head2;
            if (count1 >= count2)
            {
                for (int i = 0; i < abs; i++)
                {
                    curr1 = curr1.next;
                }
                while (curr1 != null)
                {
                    if (curr1 == curr2)
                    {
                        return curr1.data;
                    }
                    curr1 = curr1.next;
                    curr2 = curr2.next;

                }
            }
            else
            {
                for (int i = 0; i < abs; i++)
                {
                    curr2 = curr2.next;
                }
                while (curr2 != null)
                {
                    if (curr1 == curr2)
                    {
                        return curr1.data;
                    }
                    curr1 = curr1.next;
                    curr2 = curr2.next;
                }
            }
            return -1;
        }
    }
}

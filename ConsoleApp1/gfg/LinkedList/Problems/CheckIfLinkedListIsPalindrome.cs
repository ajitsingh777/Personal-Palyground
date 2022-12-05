using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Problems
{
    internal class CheckIfLinkedListIsPalindrome
    {
        public bool isPalindrom_Approach1(Node head)
        {
            if (head == null) return false;

            Stack<int> ints = new Stack<int>();
            Node curr = head;
            while (curr != null)
            {
                ints.Push(curr.data);
                curr = curr.next;
            }
            curr = head;
            while (curr != null)
            {
                if (curr.data != ints.Pop())
                {
                    return false;
                }
                curr = curr.next;
            }
            return true;

        }

        public bool isPalindrom_Approach2(Node head)
        {
            if (head == null) return false;

            Node middle = FindMiddleOfLinkedList(head);

            Node prev = null;
            Node curr = middle.next;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            curr = head;
            while (prev != null)
            {
                if (curr.data != prev.data)
                {

                    return false;
                }
                prev = prev.next;
                curr = curr.next;
            }
            return true;

        }

        private Node FindMiddleOfLinkedList(Node head)
        {
            Node Slow = head;
            Node fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                Slow = Slow.next;
            }
            return Slow;
        }
    }

}

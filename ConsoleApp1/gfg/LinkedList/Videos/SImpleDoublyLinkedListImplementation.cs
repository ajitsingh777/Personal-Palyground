using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class SImpleDoublyLinkedListImplementation
    {
        public void ImplementNode()
        {
            DoublyNode node1 = new DoublyNode(10);
            DoublyNode node2 = new DoublyNode(20);
            DoublyNode node3 = new DoublyNode(30);
            node1.next = node2;
            node2.prev = node1;
            node2.next = node3;
            node3.prev = node2;
        }

        public DoublyNode InsertAtBegining(DoublyNode head, int value)
        {
            DoublyNode newNode = new DoublyNode(value);
            if (head != null)
            {
                newNode.next = head;
                head.prev = newNode;
            }
            return newNode;
        }

        public DoublyNode ReverseDoublyLinkedList(DoublyNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            DoublyNode prev = null, curr = head;
            while (curr != null)
            {
                prev = curr.prev;
                curr.prev = curr.next;
                curr.next = prev;
                curr = curr.prev;
            }
            return prev.prev;

        }

        public DoublyNode DeleteHead(DoublyNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            head = head.next;
            head.prev = null;
            return head;
        }

        public DoublyNode DeleteLastNode(DoublyNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            DoublyNode curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.prev.next = null;
            return head;
        }

        public DoublyNode InsertAtTheEnd(DoublyNode head, int value)
        {
            DoublyNode newNode = new DoublyNode(value);
            if (head == null)
            {
                return newNode;
            }
            else
            {
                DoublyNode currNode = head;
                while (currNode.next != null)
                {
                    currNode = currNode.next;
                }
                currNode.next = newNode;
                newNode.prev = currNode;
                return head;
            }
        }
    }
}

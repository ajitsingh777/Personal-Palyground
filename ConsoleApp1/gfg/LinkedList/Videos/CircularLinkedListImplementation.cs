using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.LinkedList.Videos
{
    internal class CircularLinkedListImplementation
    {
        public void TraverseCircularLinkedList(Node head)
        {
            if (head == null) return;
            Node r = head;
            do
            {
                Console.Write(r.data + " ");
                r = r.next;
            } while (r != head);
        }

        public Node InsertBeginingInCircularLinkedList_Naive(Node head, int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                newNode.next = newNode;
            }
            else
            {
                Node curr = head;
                while (curr.next != head)
                {
                    curr.next = curr;
                }
                curr.next = newNode;
                newNode.next = head;
            }
            return newNode;
        }

        public Node InsertBeginingInCircularLinkedList_Approach2(Node head, int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                newNode.next = newNode;
                return newNode;
            }
            else
            {
                ///insert new node as secondNode and then swap there data;
                newNode.next = head.next;
                head.next = newNode;
                int temp = head.data;
                head.data = newNode.data;
                newNode.data = temp;
                return head;
            }

        }

        public Node InsertAtTheEndCL_optimal(Node head, int value)
        {
            Node tmp = new Node(value);
            if (head == null)
            {
                tmp.next = tmp;
                return tmp;
            }
            else
            {
                tmp.next = head.next;
                head.next = tmp;
                int temp = head.data;
                head.data = tmp.data;
                tmp.data = temp;
                return tmp;
            }
        }
    }
}

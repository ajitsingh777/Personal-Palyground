using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DSPractice.gfg.LinkedList.Videos
{
    public class SimpleLinkedListImplementation
    {
        public void ImplementNode()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            node1.next = node2;
            node2.next = node3;
        }
        public static void TraverseLinkedList(Node head)
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

        public static Node InsertAtBegin(Node head, int x)
        {
            Node curr = new Node(x);
            curr.next = head;
            return curr;
        }

        public static Node InsertAtEnd(Node head, int x)
        {
            if (head == null)
            {
                return new Node(x);
            }
            else
            {
                Node curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = new Node(x);
                return head;
            }
        }
        public static Node DeleteFirstNode(Node head)
        {
            if (head == null)
            {
                return null;
            }
            return head.next;
        }

        public static Node DeleteLasttNode(Node head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            else
            {
                Node curr = head.next;
                while (curr.next.next != null)
                {
                    curr = curr.next;
                }
                curr.next = null;
                return head;
            }
        }

        public static Node InsertAtGivenPosition(Node head, int x, int pos)
        {
            Node myNode = new Node(x);
            if (pos == 1)
            {
                myNode.next = head;
                return myNode;
            }
            else
            {
                Node curr = head;
                int count = 1;
                while (curr.next != null && count < pos - 1)
                {
                    curr = curr.next;
                    count++;
                }
                if (count == pos - 1)
                {
                    myNode.next = curr.next;
                    curr.next = myNode;
                }
                return head;
            }
        }

        public static int SearchInLinkedList(Node head, int x)
        {
            int pos = 1;
            while (head != null)
            {
                if (head.data == x)
                {
                    return pos;
                }
                pos++;
                head = head.next;
            }
            return -1;
        }

        public static int SearchInLinkedList_2(Node head, int x)
        {
            if (head == null)
            {
                return -1;
            }
            if (head.data == x)
            {
                return 1;
            }
            else
            {
                int res = SearchInLinkedList_2(head.next, x);
                if (res == -1)
                {
                    return -1;
                }
                else
                {
                    return res + 1;
                }
            }

        }
    }
}

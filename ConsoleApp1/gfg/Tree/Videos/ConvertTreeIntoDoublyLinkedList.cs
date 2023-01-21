using DSPractice.gfg.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class ConvertTreeIntoDoublyLinkedList
    {
        DoublyNode head;
        DoublyNode curr;
        Node prev = null;

        public DoublyNode ConvertToDoubly(Node node)
        {
            InOrder(node);
            return head;
        }
        public void Convert(Node node)
        {
            DoublyNode temp = new DoublyNode(node.key);
            if (head == null)
            {
                head = curr = temp;
            }
            else
            {

                curr.next = temp;
                temp.prev = curr;
                curr = curr.next;
            }
        }
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Convert(node);
                InOrder(node.right);
            }
        }

        /// <summary>
        /// In place approach as we are using same node and converting them to DLL node 
        /// as left as prev and right as next
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node BTToDLL(Node root)
        {
            if (root == null) return root;
            Node head = BTToDLL(root.left);
            if (prev == null)
            {
                head = root;
            }
            else
            {
                root.left = prev;
                prev.right = root;
            }
            prev = root;
            BTToDLL(root.right);

            return head;
        }
    }
}

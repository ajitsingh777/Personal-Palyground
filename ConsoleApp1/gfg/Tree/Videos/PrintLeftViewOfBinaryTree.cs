using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class PrintLeftViewOfBinaryTree
    {
        public void PrintLeftView(Node node)
        {
            if (node == null)
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    Node tempNode = queue.Dequeue();
                    if (i == 0)
                    {
                        Console.WriteLine(tempNode.key);
                    }
                    if (tempNode.left != null)
                    {
                        queue.Enqueue(tempNode.left);
                    }
                    if (tempNode.right != null)
                    {
                        queue.Enqueue(tempNode.right);
                    }
                }
            }
        }
    }
}

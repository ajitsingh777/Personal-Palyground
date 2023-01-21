using DSPractice.gfg.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class MaxWidthOfTree
    {
        public int getMaxWidth(Node root)
        {
            int result = 0;
            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int count = queue.Count;
                    result = Math.Max(result, count);
                    for (int i = 0; i < count; i++)
                    {
                        Node tempNode = queue.Dequeue();
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
            return result;
        }
    }
}

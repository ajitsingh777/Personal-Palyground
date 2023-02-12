using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class RightViewOfBinaryTree
    {
        public List<int> rightView(Node root)
        {
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            if (root != null)
            {
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Node temp = queue.Dequeue();
                        if (i == count - 1)
                        {
                            list.Add(temp.key);
                        }
                        if (temp.left != null)
                        {
                            queue.Enqueue(temp.left);
                        }
                        if (temp.right != null)
                        {
                            queue.Enqueue(temp.right);
                        }
                    }
                }
            }
            return list;
        }
    }
}

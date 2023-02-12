using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class LeftViewOfBinaryTree
    {
        public List<int> leftView(Node root)
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
                        if (i == 0)
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

        public void findLeftView(Node root, List<int> list)
        {
            if (root != null)
            {
                list.Add(root.key);
                if (root.left == null)
                {
                    findLeftView(root.right, list);
                }
                else
                {
                    findLeftView(root.left, list);
                }

            }

        }
    }
}

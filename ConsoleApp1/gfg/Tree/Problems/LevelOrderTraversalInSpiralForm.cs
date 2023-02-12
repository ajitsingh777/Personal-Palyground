using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class LevelOrderTraversalInSpiralForm
    {
        public List<int> levelOrder(Node root)
        {
            List<int> list = new List<int>();
            if (root != null)
            {
                Stack<Node> stack1 = new Stack<Node>();
                Stack<Node> stack2 = new Stack<Node>();
                stack1.Push(root);
                while (stack1.Count > 0 || stack2.Count > 0)
                {
                    while (stack1.Count > 0)
                    {
                        Node temp = stack1.Pop();
                        list.Add(temp.key);
                        if (temp.right != null)
                        {
                            stack2.Push(temp.right);
                        }
                        if (temp.left != null)
                        {
                            stack2.Push(temp.left);
                        }
                    }

                    while (stack2.Count > 0)
                    {
                        Node temp = stack2.Pop();
                        list.Add(temp.key);
                        if (temp.left != null)
                        {
                            stack1.Push(temp.left);
                        }
                        if (temp.right != null)
                        {
                            stack1.Push(temp.right);
                        }
                    }
                }
            }
            return list;
        }
    }
}

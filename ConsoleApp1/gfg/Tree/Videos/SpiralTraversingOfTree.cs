using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class SpiralTraversingOfTree
    {
        public void SpiralTraversing(Node root)
        {
            if (root is null)
            {
                return;
            }
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            stack1.Push(root);
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                if (stack1.Count > 0)
                {
                    while (stack1.Count > 0)
                    {
                        Node temp = stack1.Pop();
                        Console.Write(temp.key + " ");
                        if (temp.left is not null)
                        {
                            stack2.Push(temp.left);
                        }
                        if (temp.right is not null)
                        {
                            stack2.Push(temp.right);
                        }

                    }
                }
                else
                {
                    while (stack2.Count > 0)
                    {
                        Node temp = stack2.Pop();
                        Console.Write(temp.key + " ");
                        if (temp.right is not null)
                        {
                            stack1.Push(temp.right);
                        }
                        if (temp.left is not null)
                        {
                            stack1.Push(temp.left);
                        }
                    }
                }
            }
        }
    }
}

using DSPractice.gfg.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class PreOrderTraversalIterative
    {
        public void Traversal(Node root)
        {
            if (root is not null)
            {
                Stack<Node> nodes = new Stack<Node>();
                nodes.Push(root);
                Node curr = root;
                while (curr is not null || nodes.Count > 0)
                {
                    while (curr is not null)
                    {
                        Console.WriteLine(curr.key);
                        if (curr.right is not null)
                        {
                            nodes.Push(curr.right);
                        }
                        curr = curr.left;
                    }
                    if (nodes.Count > 0)
                        curr = nodes.Pop();
                }
            }

        }
    }
}

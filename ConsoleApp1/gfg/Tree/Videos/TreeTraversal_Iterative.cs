using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class TreeTraversalIterative
    {
        public void Traversal(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            Node curr = root;
            while (curr != null || nodes.Count > 0)
            {
                while (curr != null)
                {
                    nodes.Push(curr);
                    curr = curr.left;
                }
                curr = nodes.Pop();
                Console.WriteLine(curr.key);
                curr = curr.right;
            }
        }
    }
}

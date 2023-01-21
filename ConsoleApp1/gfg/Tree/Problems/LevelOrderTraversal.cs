using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class LevelOrderTraversal
    {
        //Function to return the level order traversal of a tree.
        public List<int> levelOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(node);
                while (queue.Count > 0)
                {
                    Node tempNode = queue.Dequeue();
                    result.Add(tempNode.key);
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
            return result;
        }
    }
}

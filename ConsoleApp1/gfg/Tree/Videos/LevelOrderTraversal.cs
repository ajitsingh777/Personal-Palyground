using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class LevelOrderTraversal
    {
        public void LevelOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node tempNode = queue.Dequeue();
                Console.WriteLine(tempNode.key);
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

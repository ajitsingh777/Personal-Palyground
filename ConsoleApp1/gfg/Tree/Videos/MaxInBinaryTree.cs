using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class MaxInBinaryTree
    {
        public int GetMaxInBinaryTree(Node node)
        {
            if (node == null) return -1;
            else return Math.Max(node.key, Math.Max(GetMaxInBinaryTree(node.left), GetMaxInBinaryTree(node.right)));
        }

        public int GetMaxInBinaryTree_Approach2(Node node)
        {
            if (node == null) return -1;
            int max = node.key;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Node node2 = queue.Dequeue();
                max = Math.Max(max, node2.key);
                queue.Enqueue(node2.left);
                queue.Enqueue(node2.right);
            }
            return max;
        }
    }
}

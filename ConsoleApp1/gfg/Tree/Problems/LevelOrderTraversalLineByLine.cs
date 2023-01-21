using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class LevelOrderTraversalLineByLine
    {
        public List<List<int>> levelOrder(Node node)
        {
            List<List<int>> result = new List<List<int>>();
            if (node != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(node);
                while (queue.Count > 0)
                {
                    int count = queue.Count;
                    List<int> list = new List<int>();
                    for (int i = 0; i < count; i++)
                    {
                        Node tempNode = queue.Dequeue();
                        list.Add(tempNode.key);
                        if (tempNode.left != null)
                        {
                            queue.Enqueue(tempNode.left);
                        }
                        if (tempNode.right != null)
                        {
                            queue.Enqueue(tempNode.right);
                        }
                    }
                    result.Add(list);
                }
            }
            return result;
        }
    }
}

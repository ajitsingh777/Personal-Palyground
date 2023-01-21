using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class PrintNodesAtkDistance
    {
        public void NodesAtKDistance(Node node, int k)
        {
            if (node == null) return;
            if (k == 0)
            {
                Console.Write(node.key + " ");
            }
            else
            {
                NodesAtKDistance(node.left, k - 1);
                NodesAtKDistance(node.right, k - 1);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class InOrderTraversal
    {
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write(node.key + " ");
                InOrder(node.right);
            }
        }
    }
}

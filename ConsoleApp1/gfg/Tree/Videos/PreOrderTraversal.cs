using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class PreOrderTraversal
    {
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.key + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class PostOrderTraversal
    {
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.key + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class HeightOfTree
    {
        public int height(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(height(node.left), height(node.right)) + 1;
            }
        }
    }
}

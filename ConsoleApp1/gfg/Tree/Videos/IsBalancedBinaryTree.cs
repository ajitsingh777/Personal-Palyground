using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class IsBalancedBinaryTree
    {
        public int IsBalanced(Node node)
        {
            if (node == null) return 0;
            int lh = IsBalanced(node.left);
            if (lh == -1) return -1;
            int rh = IsBalanced(node.right);
            if (rh == -1) return -1;
            if (Math.Abs(lh - rh) > 1) return -1;
            return Math.Max(lh, rh) + 1;

        }
    }
}

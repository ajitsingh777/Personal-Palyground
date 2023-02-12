using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class DiameterOfTree
    {
        int result = 0;
        public int calculateHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int lh = calculateHeight(root.left);
            int rh = calculateHeight(root.right);
            result = Math.Max(result, 1 + lh + rh);
            return 1 + Math.Max(lh, rh);
        }
    }
}

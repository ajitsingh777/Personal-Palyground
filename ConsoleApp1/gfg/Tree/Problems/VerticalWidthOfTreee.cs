using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class VerticalWidthOfTree
    {
        public int verticalWidth(Node root)
        {
            HashSet<int> diff = new HashSet<int>();
            width(root, 0, diff);
            return diff.Count;
        }

        public void width(Node root, int level, HashSet<int> diff)
        {
            if (root == null)
            {
                return;
            }
            width(root.left, level - 1, diff);
            diff.Add(level);
            width(root.right, level + 1, diff);
        }
    }
}

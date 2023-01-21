using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class ChildrenSumProperty
    {
        public bool isSumProperty(Node root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;
            int sum = 0;
            if (root.left != null)
            {
                sum += root.left.key;
            }
            if (root.right != null)
            {
                sum += root.right.key;
            }
            return root.key == sum && isSumProperty(root.left) && isSumProperty(root.right);
        }
    }
}

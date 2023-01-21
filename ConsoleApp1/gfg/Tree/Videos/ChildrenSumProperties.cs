using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class ChildrenSumProperties
    {
        public bool isChildrenSum(Node node)
        {
            if (node == null)
            {
                return true;
            }
            if (node.left == null && node.right == null)
            {
                return true;
            }
            int sum = 0;
            if (node.left != null)
            {
                sum += node.left.key;
            }
            if (node.right != null)
            {
                sum += node.right.key;
            }
            return node.key == sum && isChildrenSum(node.left) && isChildrenSum(node.right);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class MirrorTree
    {
        public void mirror(Node root)
        {
            if (root != null)
            {
                Node temp = root.left;
                root.left = root.right;
                root.right = temp;
                mirror(root.left);
                mirror(root.right);
            }
        }
    }
}

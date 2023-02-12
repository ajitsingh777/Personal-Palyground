using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class HeightBalancedTree
    {
        //Function to check whether a binary tree is balanced or not.
        public bool isBalanced(Node root)
        {
            if (root == null)
            {
                return true;
            }
            return Math.Abs(height(root.left) - height(root.right)) <= 1 && isBalanced(root.left) && isBalanced(root.right);
        }

        public int height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(height(root.left), height(root.right)) + 1;
        }
    }
}

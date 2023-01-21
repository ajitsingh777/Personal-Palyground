using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class CheckIfTreesAreIdentical
    {
        public bool isIdentical(Node r1, Node r2)
        {
            if (r1 == null && r2 == null) return true;
            if (r1 == null && r2 != null) return false;
            if (r1 != null && r2 == null) return false;
            return r1.key == r2.key && isIdentical(r1.left, r2.left) && isIdentical(r1.right, r2.right);
        }
    }
}

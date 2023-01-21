using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class SizeOfBinaryTree
    {
        public int GetSize(Node node)
        {
            if (node == null) return 0;
            return GetSize(node.left) + GetSize(node.right) + 1;
        }
    }
}

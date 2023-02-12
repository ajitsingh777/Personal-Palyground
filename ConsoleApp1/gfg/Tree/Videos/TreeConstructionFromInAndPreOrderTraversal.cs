using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class TreeConstructionFromInAndPreOrderTraversal
    {
        int preIndex = 0;
        public Node TreeConstruction(int[] inO, int[] preO, int iS, int iE)
        {
            if (iS > iE)
            {
                return null;
            }
            Node root = new Node(preO[preIndex++]);
            int inIndex = 0;
            for (int i = iS; i <= iE; i++)
            {
                if (inO[i] == root.key)
                {
                    inIndex = i;
                    break;
                }
            }
            root.left = TreeConstruction(inO, preO, iS, inIndex - 1);
            root.right = TreeConstruction(inO, preO, inIndex + 1, iE);
            return root;
        }
    }
}

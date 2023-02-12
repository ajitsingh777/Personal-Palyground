using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Videos
{
    internal class LeastCommonAncestorInTree
    {
        public Node LCA_Naive(Node root, int n1, int n2)
        {
            List<Node> path1 = new List<Node>();
            List<Node> path2 = new List<Node>();
            if (!FindPath(root, path1, n1) || !FindPath(root, path2, n2))
            {
                return null;
            }
            for (int i = 0; i < path1.Count && i < path2.Count; i++)
            {
                if (path1[i + 1] != path2[i + 1])
                {
                    return path1[i];
                }
            }
            return null;
        }

        public bool FindPath(Node root, List<Node> path1, int key)
        {
            if (root is null)
            {
                return false;
            }
            path1.Add(root);
            if (root.key == key)
            {
                return true;
            }
            if (FindPath(root.left, path1, key) || FindPath(root.right, path1, key))
            {
                return true;
            }
            path1.RemoveAt(path1.Count - 1);
            return false;
        }

        public Node LCA_Efficient(Node root, int n1, int n2)
        {
            if (root == null)
            {
                return null;
            }
            if (root.key == n1 || root.key == n2)
            {
                return root;
            }
            Node lca1 = LCA_Efficient(root.left, n1, n2);
            Node lca2 = LCA_Efficient(root.right, n1, n2);
            if (lca1 is not null && lca2 is not null)
            {
                return root;
            }
            if (lca1 is not null)
            {
                return lca1;
            }
            else
            {
                return lca2;
            }
        }
    }
}

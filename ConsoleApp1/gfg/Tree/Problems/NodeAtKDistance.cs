using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Tree.Problems
{
    internal class NodeAtKDistance
    {
        public int printKDistantfromLeaf(Node root, int k)
        {
            int counter = 0;
            bool[] visited = new bool[10000];
            Array.Fill(visited, false);
            findLevels(root, ref counter, visited, 0, k);
            return counter;
        }

        void findLevels(Node root, ref int counter, bool[] visited, int pathLength, int k)
        {
            if (root == null)
            {
                return;
            }
            visited[pathLength] = false;
            pathLength++;
            if (root.left == null && root.right == null
                && pathLength - k - 1 >= 0 && !visited[pathLength - k - 1])
            {

                counter++;
                visited[pathLength - k - 1] = true;
                return;
            }
            findLevels(root.left, ref counter, visited, pathLength, k);
            findLevels(root.right, ref counter, visited, pathLength, k);
        }
    }
}

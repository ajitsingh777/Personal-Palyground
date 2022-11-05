using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class SpiralMatrixTraversal
    {
        /// <summary>
        /// https://leetcode.com/problems/spiral-matrix/submissions/836143036/
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int topRow = 0, rightColumn = matrix[0].Length - 1, leftColumn = 0, bottomRow = matrix.Length - 1;
            List<int> result = new List<int>();

            while (topRow <= bottomRow && leftColumn <= rightColumn)
            {
                for (int i = leftColumn; i <= rightColumn; i++)
                {
                    result.Add(matrix[topRow][i]);
                }
                topRow++;
                for (int i = topRow; i <= bottomRow; i++)
                {
                    result.Add(matrix[i][rightColumn]);
                }
                rightColumn--;
                if (topRow <= bottomRow)
                {


                    for (int i = rightColumn; i >= leftColumn; i--)
                    {
                        result.Add(matrix[bottomRow][i]);
                    }
                }
                bottomRow--;
                if (leftColumn <= rightColumn)
                {
                    for (int i = bottomRow; i >= topRow; i--)
                    {
                        result.Add(matrix[i][leftColumn]);
                    }
                }
                leftColumn++;
            }
            return result;
        }
    }
}

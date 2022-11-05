using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class RotateImageByNinteyDegree
    {
        /// <summary>
        /// https://leetcode.com/problems/rotate-image/
        /// </summary>
        /// <param name="matrix"></param>
        public void Rotate(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;
            TransposeOfMatrix(matrix, rows, cols);
            ReverseRowsInMatrix(matrix, rows, cols);
        }
        public void TransposeOfMatrix(int[][] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < cols; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        public void ReverseRowsInMatrix(int[][] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                int start = 0, end = cols - 1;
                while (start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start] = matrix[i][end];
                    matrix[i][end] = temp;
                    start++;
                    end--;
                }
            }
        }

    }
}

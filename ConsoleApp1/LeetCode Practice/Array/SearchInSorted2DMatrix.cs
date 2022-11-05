using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class SearchInSorted2DMatrix
    {
        /// <summary>
        /// https://leetcode.com/problems/search-a-2d-matrix/
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;
            int i = 0, j = cols - 1;
            while (i < rows)
            {
                int topRight = matrix[i][j];
                if (topRight == target)
                {
                    return true;
                }
                else if (topRight > target)
                {
                    return SearchInSortedArray(matrix[i], target);
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        public bool SearchInSortedArray(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    return true;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start++;
                }
            }
            return false;
        }
    }
}

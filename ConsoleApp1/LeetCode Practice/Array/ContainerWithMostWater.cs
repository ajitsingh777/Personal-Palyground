using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class ContainerWithMostWater
    {

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int i = 0, j = height.Length - 1;
            while (i < j)
            {
                int minHeight = Math.Min(height[i], height[j]);
                maxArea = Math.Max(minHeight * (j - i), maxArea);
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxArea;
        }
    }
}

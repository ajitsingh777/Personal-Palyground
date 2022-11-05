using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-size-subarray-sum/
    /// </summary>
    internal class MinimumSubArrayLength
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = 0;
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i];
            }
            return minLength;
        }
    }
}

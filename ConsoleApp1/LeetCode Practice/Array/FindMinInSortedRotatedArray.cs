using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class FindMinInSortedRotatedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/submissions/835541659/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int start = 0, end = nums.Length - 1;
            if (nums[start] < nums[end])
            {
                return nums[start];
            }

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];

                }
                if (nums[mid - 1] > nums[mid])
                {
                    return nums[mid];

                }
                if (nums[mid] > nums[start])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return Int32.MinValue;
        }
    }
}

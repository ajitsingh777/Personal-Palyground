using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class FindPeakElement
    {
        /// <summary>
        /// https://leetcode.com/problems/find-peak-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindPeakElement1(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if ((mid == 0 && nums[mid] > nums[mid + 1]) ||
                    (mid == nums.Length - 1 && nums[mid] > nums[mid - 1]) ||
                    (mid > 0 && nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1]))
                {
                    return mid;
                }
                if (nums[mid] < nums[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return 0;
        }
    }
}

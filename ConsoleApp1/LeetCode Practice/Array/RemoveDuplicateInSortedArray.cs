using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class RemoveDuplicateInSortedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            int start = 0;
            int count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[start])
                {
                    count++;
                }

                if (count == 1 || nums[i] != nums[start])
                {

                    if (nums[i] != nums[start])
                    {
                        count = 0;
                    }
                    start++;
                    nums[start] = nums[i];
                }
            }
            return start + 1;
        }
    }
}

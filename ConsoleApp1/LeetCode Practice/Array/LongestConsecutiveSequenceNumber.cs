using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class LongestConsecutiveSequenceNumber
    {
        /// <summary>
        /// https://leetcode.com/problems/longest-consecutive-sequence/submissions/835459152/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int longestSequence = 1, currentSequence;
            if (nums.Length == 0) { return 0; }

            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    currentSequence = 1;
                    int k = nums[i];
                    while (set.Contains(k + 1))
                    {
                        k++;
                        currentSequence++;
                    }

                    longestSequence = Math.Max(longestSequence, currentSequence);
                }
            }
            return longestSequence;
        }
    }
}

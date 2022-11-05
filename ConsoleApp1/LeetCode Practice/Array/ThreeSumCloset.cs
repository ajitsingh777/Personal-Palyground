using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class ThreeSumCloset
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum-closest/submissions/834131159/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosestMethod(int[] nums, int target)
        {
            int result = 0;
            int difference = int.MaxValue;
            System.Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int start = i + 1;
                int end = nums.Length - 1;
                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    int absDifference = Math.Abs(target - sum);
                    if (absDifference < difference)
                    {
                        difference = absDifference;
                        result = sum;
                    }
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class FindFirstAndLastOccurenceInSortedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            int first, last;

            first = FirstOccurence(nums, target);
            last = LastOccurence(nums, target);

            return new int[] { first, last };
        }

        public int FirstOccurence(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            int firstOccurence = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    firstOccurence = mid;
                    if (mid == 0 || (mid > 0 && nums[mid - 1] != target))
                    {
                        return firstOccurence;
                    }
                    else
                    {
                        end = mid - 1;
                    }

                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return firstOccurence;
        }

        public int LastOccurence(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            int lasOccurence = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    lasOccurence = mid;
                    if (mid == nums.Length - 1 || (mid < nums.Length - 1 && nums[mid + 1] != target))
                    {
                        return lasOccurence;
                    }
                    else
                    {
                        start = mid + 1;
                    }

                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return lasOccurence;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LeetCode_Practice.Array
{
    internal class ThreeSum
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// Three sum triplet
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSumMethod(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int target = -nums[i];
                int front = i + 1;
                int back = nums.Length - 1;
                while (front < back)
                {
                    int sum = nums[front] + nums[back];
                    if (sum < target)
                    {
                        front++;
                    }
                    else if (sum > target)
                    {
                        back--;
                    }
                    else
                    {
                        List<int> temp = new List<int>() { nums[i], nums[front], nums[back] };
                        result.Add(temp);

                        while (front < back && nums[front] == temp[1])
                        {
                            front++;
                        }
                        while (back > front && nums[back] == nums[2])
                        {
                            back--;
                        }

                    }
                }
                while (i + 1 < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return result;
        }
    }
}

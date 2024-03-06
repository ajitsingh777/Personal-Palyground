using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.Sliding_window
{
    internal class SlidingWindowProblems
    {
        //Complete this function
        //Function to find a continuous sub-array which adds up to a given number.
        //https://www.geeksforgeeks.org/problems/subarray-with-given-sum-1587115621/1?page=1&category=sliding-window&sortBy=submissions
        public List<int> subarraySum(List<int> arr, int n, long s)
        {
            List<int> result = new List<int>() { -1 };
            int start = 0;
            long window_sum = 0;

            for (int i = 0; i < n; i++)
            {
                window_sum += arr[i];
                if (window_sum == s)
                {
                    return new List<int> { start + 1, i + 1 };
                }
                if (window_sum > s)
                {
                    while (window_sum > s)
                    {
                        window_sum -= arr[start++];

                    }
                    if (window_sum == s && start != i + 1)
                    {
                        return new List<int> { start + 1, i + 1 };
                    }
                }
            }

            return result;
        }
    }
}

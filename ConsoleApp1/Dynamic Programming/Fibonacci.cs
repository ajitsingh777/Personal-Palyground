using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.Dynamic_Programming
{
    internal class Fibonacci
    {
        //Complete this function
        //Function to find the nth fibonacci number using bottom-up approach.
        public long findNthFibonacci_bottomup(int number)
        {
            long[] dp = new long[number];
            if (number < 3)
            {
                return 1;
            }
            dp[0] = 1; dp[1] = 1;
            for (int i = 2; i < number; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[number - 1];
        }

        //Complete this function
        //Function to find the nth fibonacci number using top-down approach.
        public long findNthFibonacci_topdown(int number, long[] dp)
        {
            if (number < 3)
            {
                return 1;
            }
            if (dp[number] != 0)
            {
                return dp[number];
            }
            dp[number] = findNthFibonacci_topdown(number - 1, dp) + findNthFibonacci_topdown(number - 2, dp);
            return dp[number];

        }
    }
}

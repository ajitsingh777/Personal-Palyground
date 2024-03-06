using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.Dynamic_Programming
{
    internal class CoinChange
    {
        // Coin Change Problem - Given a set of coins and a sum, find the number of ways to make the sum using the coins
        // Example - coins[] = {1, 2, 3}, sum = 5
        // Output - 5
        // Explanation - {1, 1, 1, 1, 1}, {1, 1, 1, 2}, {1, 2, 2}, {1, 1, 3}, {2, 3}

        int[,] dp;

        public static int Recurssive_Solution(int[] coins, int n, int sum)
        {
            // if the sum is zero, then there is only one way to make the sum
            if (sum == 0)
            {
                return 1;
            }
            // if the sum is less than zero, then there is no way to make the sum
            if (sum < 0)
            {
                return 0;
            }
            // if there are no coins, then there is no way to make the sum
            if (n == 0)
            {
                return 0;
            }

            // if the last coin is greater than the sum, then we can't include the last coin
            // so we move to the next coin
            // if the last coin is less than or equal to the sum, then we have two options
            // 1. we can include the last coin and reduce the sum by the value of the last coin
            // 2. we can exclude the last coin and move to the next coin
            // we take the sum of both the options
            return Recurssive_Solution(coins, n, sum - coins[n - 1]) + Recurssive_Solution(coins, n - 1, sum);

        }

        public int DP_Solution(int[] coins, int n, int sum)
        {
            dp = new int[n + 1, sum + 1];
            return calculate_DP(coins, n, sum);
        }

        public int calculate_DP(int[] coins, int n, int sum)
        {
            // if the sum is zero, then there is only one way to make the sum
            if (sum == 0)
            {
                return 1;
            }
            // if the sum is less than zero, then there is no way to make the sum
            if (sum < 0)
            {
                return 0;
            }
            // if there are no coins, then there is no way to make the sum
            if (n == 0)
            {
                return 0;
            }


            // if the result is already calculated, then return the result
            // from the dp array
            if (dp[n, sum] != 0)
            {
                return dp[n, sum];
            }
            else
            {
                // if the last coin is greater than the sum, then we can't include the last coin
                // so we move to the next coin
                // if the last coin is less than or equal to the sum, then we have two options
                // 1. we can include the last coin and reduce the sum by the value of the last coin
                // 2. we can exclude the last coin and move to the next coin
                // we take the sum of both the options
                dp[n, sum] = calculate_DP(coins, n, sum - coins[n - 1]) + calculate_DP(coins, n - 1, sum);
                return dp[n, sum];
            }
        }
    }
}

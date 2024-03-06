using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LCS
{
    internal class LCS
    {

        // longest common subsequence without dynamic programming

        static int LCS_Recurssion(string string1, string string2, int m, int n)
        {
            // if length is zero for any of the string, then return 0 , because
            // there is no common subsequence
            if (m == 0 || n == 0)
            {
                return 0;
            }
            // if the last character of both the string is same, then it is part of the common subsequence
            // so we add 1 to the result and move to the next character of both the string
            if (string1[m - 1] == string2[n - 1])
            {
                return 1 + LCS_Recurssion(string1, string2, m - 1, n - 1);
            }
            // if the last character of both the string is not same, then we have two options 
            // 1. we can remove the last character of string1 and check for the remaining string
            // 2. we can remove the last character of string2 and check for the remaining string
            // we take the maximum of both the options
            // because we are looking for the longest common subsequence
            else
            {
                return Math.Max(LCS_Recurssion(string1, string2, m - 1, n), LCS_Recurssion(string1, string2, m, n - 1));
            }
        }

        public  static int lcs(int m, int n, string s1, string s2)
        {
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return LCS_withDP(s1, s2, m, n, dp);
        }

        // longest commmon subsequence with dynamic programming
        public static int LCS_withDP(string string1, string string2, int m, int n, int[,] dp)
        {
            // if length is zero for any of the string, then return 0 , because
            // there is no common subsequence
            if (m == 0 || n == 0)
            {
                return 0;
            }
            // if the result is already calculated, then return the result
            // from the dp array
            if (dp[m, n] != -1)
            {
                return dp[m, n];
            }

            else
            {
                // if the last character of both the string is same, then it is part of the common subsequence
                // so we add 1 to the result and move to the next character of both the string
                if (string1[m - 1] == string2[n - 1])
                {
                    dp[m, n] = 1 + LCS_withDP(string1, string2, m - 1, n - 1, dp);
                }
                // if the last character of both the string is not same, then we have two options
                // 1. we can remove the last character of string1 and check for the remaining string
                // 2. we can remove the last character of string2 and check for the remaining string
                else
                {
                    dp[m, n] = Math.Max(LCS_withDP(string1, string2, m - 1, n, dp), LCS_withDP(string1, string2, m, n - 1, dp));
                }
                return dp[m, n];
            }

        }
    }
}

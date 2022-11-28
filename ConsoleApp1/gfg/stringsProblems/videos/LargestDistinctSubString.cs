using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class LargestDistinctSubString
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/video/MTQ3MQ%3D%3D
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LargestDistinctSubString_Naive(string s)
        {
            int res = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (AreDistinct(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }
            return res;

        }

        public int LargestDistinctSubString_Approach2(string s)
        {
            int result = 1;
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                bool[] visited = new bool[256];
                for (int j = i; j < n; j++)
                {
                    if (visited[s[j]])
                    {
                        break;
                    }
                    else
                    {
                        visited[s[j]] = true;
                        result = Math.Max(result, j - i + 1);
                    }
                }
            }
            return result;
        }

        public int LargestDistinctSubString_Approach3(string s)
        {
            int[] index = new int[256];
            Array.Fill(index, -1);
            int start = 0, result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (index[s[i]] == -1)
                {
                    result = Math.Max(result, i - start + 1);
                    index[s[i]] = i;
                }
                else
                {
                    start = index[s[i]] + 1;
                    result = Math.Max(result, i - start + 1);
                    index[s[i]] = i;
                }
            }
            return result;
        }
        private bool AreDistinct(string s, int i, int j)
        {
            bool[] visited = new bool[256];

            for (int k = i; k <= j; k++)
            {
                if (visited[s[k]])
                {
                    return false;
                }
                visited[s[k]] = true;
            }
            return true;
        }
    }
}

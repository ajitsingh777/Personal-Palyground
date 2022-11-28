using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class ImplementStrStr
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/implement-strstr
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public int strstr(string s, string x)
        {
            int n = s.Length, m = x.Length;
            if (m > n)
            {
                return -1;
            }
            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (s[i + j] != x[j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

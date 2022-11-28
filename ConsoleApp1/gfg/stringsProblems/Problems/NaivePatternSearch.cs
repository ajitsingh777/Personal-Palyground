using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class NaivePatternSearch
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/naive-pattern-search-1587115620
        /// </summary>
        /// <param name="pat"></param>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool search(string pat, string txt)
        {
            int n = txt.Length, m = pat.Length;
            if (m > n)
            {
                return false;
            }
            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (txt[i + j] != pat[j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

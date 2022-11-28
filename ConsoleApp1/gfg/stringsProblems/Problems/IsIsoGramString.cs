using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class IsIsoGramString
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/check-if-a-string-is-isogram-or-not-1587115620
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool isIsogram(string s)
        {
            int n = s.Length;
            bool[] visited = new bool[26];
            for (int i = 0; i < n; i++)
            {
                if (visited[s[i] - 'a'])
                {
                    return false;
                }
                visited[s[i] - 'a'] = true;
            }
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.PatternSearch
{
    internal class PatternSearchNaiveolutions
    {
        public void PatternSearch(string s, string pattern)
        {
            if (s.Length < pattern.Length)
            {
                return;
            }
            int n = s.Length, m = pattern.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (s[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    Console.Write(i + " ");
                }
            }
        }

        /// <summary>
        /// this approach works when patten characters are distinct
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        public void PatternSearch_Approach2(string s, string pattern)
        {
            if (s.Length < pattern.Length)
            {
                return;
            }
            int n = s.Length, m = pattern.Length;

            for (int i = 0; i <= n - m;)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (s[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    Console.Write(i + " ");
                }
                ///if first character itself don't match then move like naive algorithm(above)
                if (j == 0)
                {
                    i++;
                }
                /// skip all matched character as they will not match with pattern as they are distinct
                else
                {
                    i += j;
                }
            }
        }
    }
}

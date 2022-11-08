using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.PatternSearch
{
    internal class AnagramSearch
    {
        const int CHAR = 256;
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/video/MTYwNQ%3D%3D
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public bool isAnagramAvailable(string s, string pattern)
        {
            int n = s.Length, m = pattern.Length;
            if (m > n)
            {
                return false;
            }
            int[] CT = new int[CHAR];
            int[] CP = new int[CHAR];
            for (int i = 0; i < m; i++)
            {
                CT[s[i]]++;
                CP[pattern[i]]++;
            }
            for (int i = m; i < n; i++)
            {
                if (isSame(CT, CP)) { return true; }
                CT[s[i]]++;
                CT[s[i - m]]--;
            }

            bool isSame(int[] a, int[] b)
            {
                for (int i = 0; i < CHAR; i++)
                {
                    if (a[i] != b[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }
    }
}

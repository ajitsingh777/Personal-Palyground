using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class AnagramStrings
    {
        const int CHAR = 256;

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/anagram-1587115620
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool isAnagram(string a, string b)
        {
            int n = a.Length, m = b.Length;
            if (n != m)
            {
                return false;
            }
            int[] count = new int[CHAR];

            for (int i = 0; i < n; i++)
            {
                count[a[i]]++;
                count[b[i]]--;
            }
            for (int i = 0; i < CHAR; i++)
            {
                if (count[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

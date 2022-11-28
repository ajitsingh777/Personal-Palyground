using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class LeftMostNonRepeatingCharacter
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/non-repeating-character-1587115620
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public char nonrepeatingCharacter(string s)
        {
            int[] count = new int[26];
            Array.Fill(count, -1);
            int result = Int32.MaxValue;

            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i] - 'a'] == -1)
                {
                    count[s[i] - 'a'] = i;
                }
                else
                {
                    count[s[i] - 'a'] = -2;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (count[i] >= 0)
                {
                    result = Math.Min(result, count[i]);
                }
            }

            return result == Int32.MaxValue ? '$' : s[result];

        }
    }
}

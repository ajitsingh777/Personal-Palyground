using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class MaximumOccuringCharacter
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/maximum-occuring-character-1587115620
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public char getMaxOccuringChar(string s)
        {
            int[] count = new int[256];
            int max = -1, index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }
            for (int i = 0; i < 256; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    index = i;
                }
            }
            return (char)index;
        }
    }
}

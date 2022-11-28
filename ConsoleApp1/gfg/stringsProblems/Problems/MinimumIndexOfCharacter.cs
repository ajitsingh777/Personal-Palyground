using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class MinimumIndexOfCharacter
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/minimum-indexed-character-1587115620
        /// </summary>
        /// <param name="str"></param>
        /// <param name="patt"></param>
        /// <returns></returns>
        public int minIndexChar(string str, string patt)
        {
            int[] count = new int[256];

            for (int i = 0; i < patt.Length; i++)
            {
                count[patt[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (count[str[i]] > 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

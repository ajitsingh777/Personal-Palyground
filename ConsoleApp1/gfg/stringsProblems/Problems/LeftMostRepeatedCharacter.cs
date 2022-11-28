using DSPractice.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class LeftMostRepeatedCharacter
    {
        const int CHAR = 256;
        //Complete this function

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/repeating-character-first-appearance-leftmo
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int repeatedCharacter(string s)
        {
            bool[] visited = new bool[CHAR];
            int result = -1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (visited[s[i]])
                {
                    result = i;
                }
                else
                {
                    visited[s[i]] = true;
                }
            }
            return result;
        }
    }
}

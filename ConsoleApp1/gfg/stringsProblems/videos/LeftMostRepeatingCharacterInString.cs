using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class LeftMostRepeatingCharacterInString
    {
        ///256 for all ascii character if only english alphabates the array length can be 52
        const int CHAR = 256;

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/video/MTYxMg%3D%3D
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LeftMostRepeatingCharacter(string s)
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

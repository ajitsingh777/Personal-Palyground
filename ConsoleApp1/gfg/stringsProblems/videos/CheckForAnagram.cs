using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class CheckForAnagram
    {
        ///256 for all ascii character if only english alphabates the array length can be 52
        const int CHAR = 256;
        /// <summary>
        /// increase count of character when it's present in first string and decrease it when it's also present in seconf string 
        /// at the end count of every character should be zero
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool checkIfTwoStringsAreAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            char[] count = new char[CHAR];

            for (int i = 0; i < s1.Length; i++)
            {
                count[s1[i]]++;
                count[s2[i]]--;
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

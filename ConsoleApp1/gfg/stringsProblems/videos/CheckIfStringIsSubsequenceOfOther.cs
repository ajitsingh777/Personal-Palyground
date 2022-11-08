using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class CheckIfStringIsSubsequenceOfOther
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/video/MjMyNw%3D%3D
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool IsSubsequenceOfOther(string s1, string s2)
        {
            int i = 0, j = 0;
            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] == s2[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return j == s2.Length;
        }

        public bool IsSubsequenceOfOther_Recurssive(string s1, string s2, int i = 0, int j = 0)
        {


            if (j == s2.Length)
            {
                return true;
            }
            if (i == s1.Length)
            {
                return false;
            }
            if (s1[i] == s2[j])
            {
                return IsSubsequenceOfOther_Recurssive(s1, s2, ++i, ++j);
            }
            else
            {
                return IsSubsequenceOfOther_Recurssive(s1, s2, ++i, j);
            }

        }
    }
}

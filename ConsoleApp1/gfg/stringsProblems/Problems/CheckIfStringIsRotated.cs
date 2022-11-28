using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class CheckIfStringIsRotated
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/check-if-string-is-rotated-by-two-places-1587115620
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool isRotated(string str1, string str2)
        {
            int m = str1.Length, n = str2.Length;
            if (m != n)
            {
                return false;
            }
            int k = 2;
            char[] chars = str1.ToCharArray();
            reverseString(chars, 0, k - 1);
            reverseString(chars, k, n - 1);
            reverseString(chars, 0, n - 1);
            if (new string(chars).Equals(str2)) { return true; }

            chars = str1.ToCharArray();
            reverseString(chars, 0, n - k - 1);
            reverseString(chars, n - k, n - 1);
            reverseString(chars, 0, n - 1);
            if (new string(chars).Equals(str2)) { return true; }
            return false;
        }

        //Complete this function
        public bool areRotations(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            return (a + a).IndexOf(b) >= 0;
        }

        private void reverseString(char[] str, int start, int end)
        {
            while (start < end)
            {
                char temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }

    }
}

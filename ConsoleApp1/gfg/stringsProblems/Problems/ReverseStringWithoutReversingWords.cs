using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class ReverseStringWithoutReversingWords
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/reverse-words-in-a-given-string5459
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string reverseWords(string s)
        {
            int start = 0;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '.')
                {
                    reverse(chars, start, i - 1);
                    start = i + 1;
                }
            }
            reverse(chars, start, chars.Length - 1);
            reverse(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private void reverse(char[] chars, int start, int end)
        {
            while (start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class PrintMobileTyping
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/keypad-typing0119
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string printNumber(string s)
        {
            int[] mapping = new int[26];

            fillMapping(mapping);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(mapping[s[i] - 'a']);
            }

            return sb.ToString();
        }

        public void fillMapping(int[] mapping)
        {
            int k = 2, m;
            for (int i = 0; i < 26;)
            {
                m = 3;
                if (k == 7 || k == 9)
                {
                    m++;
                }
                while (m > 0 && i < 26)
                {
                    mapping[i++] = k;
                    m--;
                }
                k++;
            }
        }


    }
}

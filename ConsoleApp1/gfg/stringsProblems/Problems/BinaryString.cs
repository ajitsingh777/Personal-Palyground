using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class BinaryString
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/binary-string-1587115620
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public long binarySubstring(int n, string a)
        {
            int res = 0, count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == '1')
                {
                    res += count;
                    count++;
                }
            }
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class IsoMorphicStrings
    {
        const int CHAR = 256;
        //Complete this function

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/problem/isomorphic-strings-1587115620
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool areIsomorphic(string a, string b)
        {
            int m = a.Length, n = b.Length;
            if (m != n)
            {
                return false;
            }
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
            Dictionary<char, char> keyValuePairs2 = new Dictionary<char, char>();

            for (int i = 0; i < m; i++)
            {
                if (!keyValuePairs.ContainsKey(a[i]))
                {
                    keyValuePairs.Add(a[i], b[i]);
                }
                if (!keyValuePairs2.ContainsKey(b[i]))
                {
                    keyValuePairs2.Add(b[i], a[i]);
                }
                if (!(keyValuePairs[a[i]] == b[i] && keyValuePairs2[b[i]] == a[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.PatternSearch
{
    internal class KMPAlgorithm
    {
        public void FillLPS(string s, int[] lps)
        {
            int n = s.Length, len = 0;
            lps[0] = 0;
            int i = 1;
            while (i < n)
            {
                if (s[i] == s[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len == 0)
                    {
                        lps[i] = 0;
                        i++;
                    }
                    else
                    {
                        len = lps[len - 1];
                    }
                }
            }
        }

        public void KMP(string s, string pattern)
        {
            int n = s.Length;
            int m = pattern.Length;

            if (m > n)
            {
                return;
            }
            int[] lps = new int[m];
            int i = 0, j = 0;
            FillLPS(pattern, lps);
            while (i < n)
            {
                if (s[i] == pattern[j]) { i++; j++; }
                if (j == m)
                {
                    Console.Write(i - j);
                    j = lps[j - 1];
                }
                else if (i < n && s[i] != pattern[j])
                {
                    if (j == 0)
                    {
                        i++;
                    }
                    else
                    {
                        j = lps[j - 1];
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class RemoveAndConcatenate
    {
        public string concatenatedString(string s1, string s2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int m = s1.Length, n = s2.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (!map.ContainsKey(s2[i]))
                {
                    map.Add(s2[i], 1);
                }
            }
            for (int i = 0; i < m; i++)
            {
                if (!map.ContainsKey(s1[i]))
                {
                    sb.Append(s1[i]);
                }
                else
                {
                    map[s1[i]] = 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (map[s2[i]] == 1)
                {
                    sb.Append(s2[i]);
                }
            }

            return sb.Length == 0 ? sb.Append("-1").ToString() : sb.ToString();
        }
    }
}

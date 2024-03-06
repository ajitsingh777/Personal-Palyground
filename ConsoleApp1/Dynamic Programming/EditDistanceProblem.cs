using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.Dynamic_Programming
{
    internal class EditDistanceProblem
    {
        public static int Recurrsive_Solution(string s1, string s2, int m, int n)
        {
            if (m == 0) return n;
            if (n == 0) return m;
            if (s1[m - 1] == s2[n - 1])
            {
                return Recurrsive_Solution(s1, s2, m - 1, n - 1);

            }
            else
            {
                return 1 + Math.Min(Recurrsive_Solution(s1, s2, m - 1, n), Math.Min(Recurrsive_Solution(s1, s2, m, n - 1), Recurrsive_Solution(s1, s2, m - 1, n - 1)));
            }
        }
    }
}

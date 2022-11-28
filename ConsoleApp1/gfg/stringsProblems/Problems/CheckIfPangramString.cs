using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class CheckIfPangramString
    {
        public bool checkPangram(string s)
        {
            int[] count = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }
            for (int i = 65; i <= 90; i++)
            {
                if (count[i] == 0 && count[i + 32] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

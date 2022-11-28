using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.Problems
{
    internal class SumOfIntegerInString
    {
       
        public int findSum(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string number = "";
                while (i < s.Length && Char.IsDigit(s[i]))
                {
                    number += s[i];
                    i++;
                }
                if (number.Length > 0)
                {
                    result += int.Parse(number);
                }
            }
            return result;
        }
    }
}

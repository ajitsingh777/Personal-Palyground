using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.PatternSearch
{
    internal class CheckIfStringIsRotationOfOther
    {
        /// <summary>
        /// concate any string twice and then check if second string is present in this concatenated string
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool IsRotationOfOther(string s1, string s2)
        {
            if (s1.Length != s2.Length) { return false; }
            return (s1 + s1).IndexOf(s2) > 0;
        }
    }
}

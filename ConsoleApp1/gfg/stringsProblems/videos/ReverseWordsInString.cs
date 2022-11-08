using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class ReverseWordsInString
    {
        /// <summary>
        /// using Stack
        /// </summary>
        /// <param name="s"></param>
        public void ReverseWords_Approach1(string s)
        {
            int start = 0;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    stack.Push(s.Substring(start, i - start));
                    start = i + 1;
                }
            }
            stack.Push(s.Substring(start, s.Length - start));

            s = "";
            for (int i = stack.Count; i > 0; i--)
            {
                s += stack.Pop() + " ";
            }

            Console.WriteLine(s.Trim());

        }

        /// <summary>
        /// reverse every word in string and then reverse the whole word
        /// </summary>
        /// <param name="s"></param>
        public void ReverseWords_Approach2(string s)
        {
            char[] chars = s.ToCharArray();
            int start = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    reverse(chars, start, i - 1);
                    start = i + 1;
                }
            }
            reverse(chars, start, chars.Length - 1);
            reverse(chars, 0, chars.Length - 1);
            s = new string(chars);
            Console.WriteLine(s);
        }

        public void reverse(char[] chars, int start, int end)
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

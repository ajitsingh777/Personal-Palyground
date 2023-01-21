using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Stack.Video
{
    internal class BalancedParenthesis
    {
        public bool IsBalanced(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (stack.Count == 0)
                {
                    if (str[i] == ']' || str[i] == '}' || str[i] == ')')
                    {
                        return false;
                    }
                    stack.Push(str[i]);
                }
                else if (str[i] == ']')
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (str[i] == '}')
                {
                    if (stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (str[i] == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(str[i]);
                }

            }
            return stack.Count == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Stack.Video
{
    internal class NextGreaterElement
    {
        public void Efficient_Approach(int[] arr)
        {
            int n = arr.Length;
            Stack<int> spans = new Stack<int>();
            spans.Push(arr[n - 1]);
            Console.Write(-1 + " ");
            for (int i = n - 2; i > 0; i--)
            {
                while (spans.Count > 0 && spans.Peek() <= arr[i])
                {
                    spans.Pop();
                }
                int nextGreater = spans.Count == 0 ? -1 : spans.Peek();
                Console.Write(nextGreater + " ");
                spans.Push(arr[i]);
            }
        }
    }
}

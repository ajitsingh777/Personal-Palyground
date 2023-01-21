using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Stack.Video
{
    internal class PreviousGreaterElement
    {
        public void Naive_Approach(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int greater = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[i])
                    {
                        greater = arr[j];
                        break;
                    }
                }
                Console.Write(greater + " ");
            }
        }

        public void Efficint_Approach(int[] arr)
        {
            Stack<int> spans = new Stack<int>();
            spans.Push(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                while (spans.Count > 0 && spans.Peek() <= arr[i])
                    spans.Pop();
                int greater = spans.Count == 0 ? -1 : spans.Peek();
                Console.Write(greater + " ");
                spans.Push(arr[i]);
            }
        }
    }
}

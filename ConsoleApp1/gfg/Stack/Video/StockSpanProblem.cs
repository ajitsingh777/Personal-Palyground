using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Stack.Video
{
    internal class StockSpanProblem
    {
        public void Naive_Approach(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int span = 1;
                for (int j = i - 1; j >= 0 && arr[j] <= arr[i]; j--)
                    span++;
                Console.Write(span + " ");

            }
        }

        public void Efficient_problem(int[] arr)
        {
            Stack<int> spans = new Stack<int>();
            spans.Push(0);
            Console.Write(1 + " ");
            for (int i = 1; i < arr.Length; i++)
            {
                while (spans.Count > 0 && arr[spans.Peek()] <= arr[i])
                    spans.Pop();
                int span = spans.Count == 0 ? i + 1 : i - spans.Peek();
                Console.Write(span + " ");
                spans.Push(i);
            }
        }
    }
}

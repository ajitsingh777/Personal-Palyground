using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.Stack.Video
{
    internal class ImplementTwoStacksInArray
    {
        int[] arr;
        int capacity, top1, top2;
        public ImplementTwoStacksInArray(int n)
        {
            arr = new int[n];
            capacity = n;
            top1 = -1;
            top2 = n;
        }
        public bool push1(int n)
        {
            if (top1 < top2 - 1)
            {
                top1++;
                arr[top1] = n;
                return true;
            }
            return false;
        }
        public bool push2(int n)
        {
            if (top1 < top2 - 1)
            {
                top2--;
                arr[top2] = n;
                return true;
            }
            return false;
        }
        public int pop1()
        {
            if (top1 >= 0)
            {
                int result = arr[top1];
                top1--;
                return result;
            }
            return Int32.MaxValue;
        }
        public int pop2()
        {
            if (top2 < capacity)
            {
                int result = arr[top2];
                top2++;
                return result;
            }
            return Int32.MaxValue;
        }
        public int size1()
        {
            return top1 + 1;
        }
        public int size2()
        {
            return capacity - top2;
        }
    }
}

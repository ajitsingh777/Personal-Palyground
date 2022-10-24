using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recurssion
{
    internal class RecurssionPractice
    {
        internal void SumOfN(int number, int sum = 0)
        {
            if (number < 1)
            {
                Console.WriteLine(sum);
                return;
            }
            SumOfN(number - 1, sum + number);
        }

        ///1,2,3,4,5,6
        internal void ReverseAnArray(int[] arr)
        {
            int length = arr.Length - 1;
            int lengthToTravers= length%2==0 ? length/2+1 : length/2;  
            for (int i = 0; i < lengthToTravers; i++)
            {
                int temp = arr[i];
                arr[i] = arr[length-i];
                arr[length-i] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        internal void SwapArrayWithRecurssion(int[] arr, int start, int end)
        {
            if (start < end)
            {
                swap(arr, start, end);
                SwapArrayWithRecurssion(arr, start + 1, end - 1);
            }    
        }

        internal void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        private void swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }

    }
}

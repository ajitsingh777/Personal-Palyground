using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    internal class MergeSortClass
    {
        internal void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + (end - start) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr,start,mid,end);
            }
        }

        private void Merge(int[] arr, int start, int mid ,int end)
        {
            int i = start;
            int j = mid + 1;
            int[] tempArray = new int[1000];
            int f = start;

            while(i<=mid && j <= end)
            {
                if(arr[i] <= arr[j])
                {
                    tempArray[f] = arr[i];
                    i++;
                }
                else
                {
                    tempArray[f] = arr[j];
                    j++;
                }
                f++;
            }
            if (i > mid)
            {
                while (j <= end)
                {
                    tempArray[f++]=arr[j++];
                }
            }
            else
            {
                while (i <= mid)
                {
                    tempArray[f++] = arr[i++];
                }
            }

            for (f=start; f<=end; f++)
            {
                arr[f] = tempArray[f];
            }
        }

        internal void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

    }
}

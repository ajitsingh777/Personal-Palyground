using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Sorting
{
    internal class MergeSort
    {
        internal void MergeSortAlgorithm(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + (end - start) / 2;
                MergeSortAlgorithm(arr, start, mid);
                MergeSortAlgorithm(arr, mid + 1, end);
                MergeSortedArrays(arr, start, mid, end);
            }
        }

        internal void MergeSortedArrays(int[] arr, int start, int mid, int end)
        {
            int[] tempArray = new int[end - start + 1];
            int i = start, j = mid + 1;
            int k = 0;
            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    tempArray[k++] = arr[i++];
                }
                else
                {
                    tempArray[k++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                tempArray[k++] = arr[i++];
            }
            while (j <= mid)
            {
                tempArray[k++] = arr[j++];
            }
            for (int t = 0; t < k; t++)
            {
                arr[t + start] = tempArray[t];
            }
        }

        internal void IntersectionOfTwoSortedArrays(int[] arr, int[] brr)
        {
            int i = 0, j = 0;
            int m = arr.Length, n = brr.Length;
            while (i < m && j < n)
            {
                if (i > 0 && arr[i - 1] == arr[i])
                {
                    i++;
                    continue;
                }
                if (arr[i] < brr[j])
                {
                    i++;
                }
                else if (arr[i] > brr[j])
                {
                    j++;
                }
                else
                {
                    Console.Write(arr[i] + " ");
                    i++;
                    j++;
                }
            }
        }

        internal int MergeSortIversionCountAlgorithm(int[] arr, int start, int end)
        {
            int res = 0;
            if (start < end)
            {
                int mid = start + (end - start) / 2;
                res += MergeSortIversionCountAlgorithm(arr, start, mid);
                res += MergeSortIversionCountAlgorithm(arr, mid + 1, end);
                res += MergeSortedArraysAndCountInversion(arr, start, mid, end);
            }
            return res;
        }

        internal int MergeSortedArraysAndCountInversion(int[] arr, int start, int mid, int end)
        {
            int[] tempArray = new int[end - start + 1];
            int i = start, j = mid + 1;
            int k = 0;
            int count = 0;
            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    tempArray[k++] = arr[i++];
                }
                else
                {
                    tempArray[k++] = arr[j++];
                    /// if right array element is smaller than left array than all other elements also will be larger than 
                    /// this element as sorted array so these all are inversion
                    count += (mid + 1) - i;
                }
            }
            while (i <= mid)
            {
                tempArray[k++] = arr[i++];
            }
            while (j <= end)
            {
                tempArray[k++] = arr[j++];
            }
            for (int t = 0; t < k; t++)
            {
                arr[t + start] = tempArray[t];
            }

            return count;
        }
    }
}

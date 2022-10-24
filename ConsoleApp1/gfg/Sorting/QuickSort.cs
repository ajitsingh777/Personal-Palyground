using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Sorting
{
    internal class QuickSort
    {
        #region Quick Sort By Lomuto Partition
        internal void QuickSortByLomutoPartition(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = LomutoPartition(arr, start, end);
                QuickSortByLomutoPartition(arr, start, pivot - 1);
                QuickSortByLomutoPartition(arr, pivot + 1, end);
            }
        }

        /// <summary>
        /// Lomuto partition take last element as pivot and 
        /// and all smaller element to pivot at left window
        /// then at the end put pivot to the next to smaller elements
        /// [smallerElements,pivot,bigger elements]
        /// at the end pivot will be it's correct place and all smaller elements than pivot will be before
        /// pivot and all larger elements will be after pivot
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        internal int LomutoPartition(int[] arr, int low, int high)
        {
            int i = low - 1, j = low;
            int pivot = arr[high];
            for (; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[j];
            arr[j] = temp2;
            return i + 1;
        }
        #endregion

        #region Quick Sort by Hoare Partition
        internal void QuickSortByHoarePartition(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = HoarePartition(arr, low, high);
                QuickSortByHoarePartition(arr, low, pivot);
                QuickSortByHoarePartition(arr, pivot + 1, high);
            }
        }

        internal int HoarePartition(int[] arr, int low, int high)
        {
            int i = low - 1, j = high + 1;
            int pivot = arr[low];
            while (true)
            {
                do
                {
                    i++;
                } while (arr[i] < pivot);
                do
                {
                    j--;
                } while (arr[j] > pivot);
                if (i >= j)
                {
                    return j;
                }
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        #endregion

        internal int KthSmallestElement(int[] arr, int low, int high, int k)
        {
            while (low <= high)
            {
                int pivot = LomutoPartition(arr, low, high);

                if (pivot == k - 1)
                {
                    return arr[pivot];
                }
                else if (pivot > k - 1)
                {
                    high = pivot - 1;
                }
                else
                {
                    low = pivot + 1;
                }
            }
            return -1;
        }
    }
}

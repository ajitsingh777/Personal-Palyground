using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Sorting
{
    internal class SortingProblems
    {
        //Function to find minimum difference between any pair of elements in an array.
        public int MinimumDifference(int[] arr, int n)
        {
            System.Array.Sort(arr);
            int min = Int32.MaxValue;

            for (int i = 1; i < n; i++)
            {
                min = Math.Min(min, arr[i] - arr[i - 1]);
            }
            return min;
        }

        //Function to sort the array using bubble sort algorithm.
        public void BubbleSort(int[] arr, int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        internal void Insert(int[] arr, int i)
        {
            int j = i - 1;
            int key = arr[i];
            while (j >= 0 && arr[j] > arr[i])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }

        public void InsertionSort(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                Insert(arr, i);
            }
        }



        public long inversionCount(long[] arr, long N)
        {
            return MergeSortInversionCount(arr, 0, N - 1);
        }

        public long MergeSortInversionCount(long[] arr, long low, long high)
        {
            long count = 0;
            if (low < high)
            {
                long mid = low + (high - low) / 2;
                count += MergeSortInversionCount(arr, low, mid);
                count += MergeSortInversionCount(arr, mid + 1, high);
                count += CountInversion(arr, low, mid, high);
            }
            return count;
        }
        public long CountInversion(long[] arr, long low, long mid, long high)
        {
            long[] tempArray = new long[high - low + 1];
            long i = low, j = mid + 1;
            long k = 0;
            long count = 0;
            while (i <= mid && j <= high)
            {
                if (arr[i] <= arr[j])
                {
                    tempArray[k++] = arr[i++];
                }
                else
                {
                    tempArray[k++] = arr[j++];
                    count += (mid + 1) - i;
                }
            }
            while (i <= mid)
            {
                tempArray[k++] = arr[i++];
            }
            while (j <= high)
            {
                tempArray[k++] = arr[j++];
            }
            for (int m = 0; m < k; m++)
            {
                arr[low + m] = tempArray[m];
            }
            return count;
        }

        //arr1,arr2 : the arrays
        // n, m: size of arrays
        //Function to return a list containing the union of the two arrays.
        public List<int> findUnion(int[] arr1, int[] arr2, int n, int m)
        {
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
            while (i < n && j < m)
            {
                while (i < n - 1 && arr1[i] == arr1[i + 1])
                {
                    i++;
                }
                while (j < m - 1 && arr2[j] == arr2[j + 1])
                {
                    j++;
                }
                if (arr1[i] < arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    list.Add(arr2[j]);
                    j++;
                }
                else
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
            }
            while (i < n)
            {
                while (i < n - 1 && arr1[i] == arr1[i + 1])
                {
                    i++;
                }
                list.Add(arr1[i]);
                i++;
            }

            while (j < m)
            {
                while (j < m - 1 && arr2[j] == arr2[j + 1])
                {
                    j++;
                }

                list.Add(arr2[j]);
                j++;
            }
            return list;
        }

        public List<int> printIntersection(int[] arr1, int[] arr2, int n, int m)
        {
            int i = 0, j = 0;
            List<int> list = new List<int>();
            while (i < n && j < m)
            {
                while (i < n - 1 && arr1[i] == arr1[i + 1])
                {
                    i++;
                }
                if (arr1[i] == arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return list;
        }

        //Function to partition the array around the range such 
        //that array is divided into three parts.
        public void ThreeWayPartition(int[] arr, int a, int b)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                if (arr[mid] < a)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[low];
                    arr[low] = temp;
                    low++;
                    mid++;
                }
                else if (arr[mid] > b)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
                else
                {
                    mid++;
                }
            }
        }

        //Function to find triplets with zero sum.
        public bool findTriplets(int[] arr, int n)
        {
            System.Array.Sort(arr);

            for (int i = 0; i < n - 2; i++)
            {
                int remainder = arr[i];
                int start = i + 1;
                int end = arr.Length - 1;
                while (start < end)
                {
                    int sum = remainder + arr[start] + arr[end];
                    if (sum == 0)
                    {
                        return true;
                    }
                    if (sum > 0)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            }
            return false;
        }

        //Function to arrange all letters of a string in lexicographical 
        //order using Counting Sort.

        /// count sort is useful when range is small as here range is only 26
        public string countSort(string arr)
        {
            int[] count = new int[26];
            for (int i = 0; i < arr.Length; i++)
            {
                //subtract 97 from ASCII value of character as a has ascii value of 97 so it should come at 0th position
                count[arr[i] - 97]++;
            }
            for (int i = 1; i < 26; i++)
            {
                count[i] += count[i - 1];
            }
            char[] output = new char[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - 97] - 1] = arr[i];
                count[arr[i] - 97]--;
            }
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < output.Length; i++)
            {
                stringBuilder.Append(output[i]);
            }
            return stringBuilder.ToString();
        }

        // The function should do the stated modifications in the given array arr[]
        // Do not return anything.

        // arr[]: Input Array
        // n: Size of the Array arr[]
        //Function to segregate 0s, 1s and 2s in sorted increasing order.
        public void Segragate012(int[] arr, int n)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                if (arr[mid] < 1)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[low];
                    arr[low] = temp;
                    low++;
                    mid++;
                }
                else if (arr[mid] > 1)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
                else
                {
                    mid++;
                }
            }
        }

        //Function to find if there exists a triplet in the 
        //array A[] which sums up to X.
        public bool Find3Numbers(int[] arr, int n, int X)
        {
            System.Array.Sort(arr);

            for (int i = 0; i < n - 2; i++)
            {
                int remainder = X - arr[i];
                int start = i + 1;
                int end = arr.Length - 1;
                while (start < end)
                {
                    int sum = arr[start] + arr[end];
                    if (sum == remainder)
                    {
                        return true;
                    }
                    if (sum > remainder)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            }
            return false;
        }

        //Function to find the kth smallest element in the array.
        public int kthSmallest(int[] arr, int n, int k)
        {
            if (k > n)
            {
                return -1;
            }
            return KthSmallestElementi(arr, 0, n - 1, k);
        }

        public int KthSmallestElementi(int[] arr, int low, int high, int k)
        {
            if (low <= high)
            {
                int p = LomutoPartition(arr, low, high);
                if (p == k - 1)
                {
                    return arr[p];
                }
                else if (p < k - 1)
                {
                    return KthSmallestElementi(arr, p + 1, high, k);
                }
                else
                {
                    return KthSmallestElementi(arr, low, p - 1, k);
                }
            }
            return -1;
        }

        public int LomutoPartition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1, j = low;
            while (j < high)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                j++;
            }
            int temp2 = arr[high];
            arr[high] = arr[i + 1];
            arr[i + 1] = temp2;
            return i + 1;
        }

        // A, B, and C: input sorted arrays
        //Function to merge three sorted vectors or arrays 
        //into a single vector or array.
        public List<int> MergeThree(int[] A, int[] B, int[] C)
        {
            int i = 0, j = 0, k = 0;
            int n = A.Length, m = B.Length, p = C.Length;
            List<int> result = new List<int>();

            while (i < n && j < m && k < p)
            {
                if (A[i] <= B[j] && A[i] <= C[k])
                {
                    result.Add(A[i++]);
                }
                else if (B[j] < A[i] && B[j] <= C[k])
                {
                    result.Add(B[j++]);
                }
                else
                {
                    result.Add(C[k++]);
                }
            }
            if (i >= n)
            {
                while (j < m && k < p)
                {
                    if (B[j] <= C[k])
                    {
                        result.Add(B[j++]);
                    }
                    else
                    {
                        result.Add(C[k++]);
                    }
                }
            }

            if (j >= m)
            {
                while (i < n && k < p)
                {
                    if (A[i] <= C[k])
                    {
                        result.Add(A[i++]);
                    }
                    else
                    {
                        result.Add(C[k++]);
                    }
                }
            }
            if (k >= p)
            {
                while (i < n && j < m)
                {
                    if (A[i] <= B[j])
                    {
                        result.Add(A[i++]);
                    }
                    else
                    {
                        result.Add(B[j++]);
                    }
                }
            }
            while (i < n)
            {
                result.Add(A[i++]);
            }
            while (j < m)
            {
                result.Add(B[j++]);
            }
            while (k < p)
            {
                result.Add(C[k++]);
            }
            return result;
        }

        //Function to sort the array according to difference with given number.
        internal void sortABS(int[] arr, int n, int k)
        {
            List<NubmerWithDiff> nubmerWithDiffs = new List<NubmerWithDiff>();
            for (int i = 0; i < n; i++)
            {
                nubmerWithDiffs.Add(new NubmerWithDiff() { number = arr[i], diff = Math.Abs(arr[i] - k) });
            }
            nubmerWithDiffs.Sort(new Comparison<NubmerWithDiff>((x, y) => { return x.diff - y.diff; }));
            for (int i = 0; i < n; i++)
            {
                arr[i] = nubmerWithDiffs[i].number;
            }
        }

        //Function to find the minimum number of platforms required at the
        //railway station such that no train waits.
        public int findPlatform(int[] arr, int[] dep, int n)
        {
            System.Array.Sort(arr);
            System.Array.Sort(dep);
            int ans = 1;
            int j = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > dep[j])
                {
                    j++;
                }
                else
                {
                    ans++;
                }
            }
            return ans;
        }

        public int Closer(int[] arr, int n, int m)
        {
            int start = 0, end = n;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == m)
                {
                    return mid;
                }
                else if (mid != start && arr[mid - 1] == m)
                {
                    return mid - 1;
                }
                else if (mid != end - 1 && arr[mid + 1] == m)
                {
                    return mid + 1;
                }
                else if (arr[mid] < m)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }

        public void merge2(int[] arr1, int[] arr2, int n, int m)
        {
            int arr1_end = n - 1, arr2_start = 0;
            while (arr1_end >= 0 && arr2_start < m)
            {
                if (arr1[arr1_end] > arr2[arr2_start])
                {
                    int temp = arr1[arr1_end];
                    arr1[arr1_end] = arr2[arr2_start];
                    arr2[arr2_start] = temp;
                    arr1_end--;
                    arr2_start++;
                }
                else
                {
                    break;

                }
            }
            System.Array.Sort(arr1);
            System.Array.Sort(arr2);
        }

        //Function to count the number of possible triangles.
        public int FindNumberOfTriangles(int[] arr, int n)
        {
            int totaTraingle = 0;
            System.Array.Sort(arr);

            for (int i = n - 1; i >= 2; i--)
            {
                int[,] test = new int[3, 2];
                int low = 0;
                int high = i - 1;
                while (low < high)
                {
                    if (arr[low] + arr[high] > arr[i])
                    {
                        totaTraingle += (high - low);
                        high--;
                    }
                    else
                    {
                        low++;
                    }
                }

            }
            return totaTraingle;
        }
    }

    class NubmerWithDiff
    {
        public int number { get; set; }
        public int diff { get; set; }
    }
}

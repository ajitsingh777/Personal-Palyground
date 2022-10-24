using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal partial class ArrayPractice
    {
        #region max value problem
        internal int MaxNumberInArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        internal int SecondMax(int[] arr)
        {
            int max = Int32.MinValue, secondMax = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < max && arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }
            return secondMax;
        }
        #endregion

        #region sorted array problem
        internal bool isArraySorted(int[] arr)
        {
            if (arr.Length <= 2) return true;
            int i = 0;
            return arr[0] < arr[1] ? isArraAscendent() : isArrayDesendent();

            bool isArraAscendent()
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1]) return false;
                }
                return true;
            }

            bool isArrayDesendent()
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1]) return false;
                }
                return true;
            }
        }
        #endregion

        #region remove deuplivate value
        internal int RemoveDuplicate(int[] arr)
        {
            int i = 0;
            for (int j = 1; j < arr.Length; j++)
            {

                if (arr[i] != arr[j])
                {
                    i++;
                    arr[i] = arr[j];
                }
            }
            return i + 1;
        }
        #endregion

        #region rotate array by ke(lef or right)

        /// <summary>
        /// to left shift array by k first reverse first k elements, 
        /// then reverse last n-k element and at the end reverse the whole array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        internal void RotateLeftByK(int[] arr, int k)
        {
            k = k % arr.Length;
            reverseArray(arr, 0, k - 1);
            reverseArray(arr, k, arr.Length - 1);
            reverseArray(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// to rotate array right by k ,  rotate first n-k elements
        /// then rotate last k elements and in the end
        /// rotate whole array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        internal void RotateArrayRightByK(int[] arr, int k)
        {
            int length = arr.Length - 1;
            k = k % arr.Length;

            reverseArray(arr, 0, length - k - 1);
            reverseArray(arr, length - k, length);
            reverseArray(arr, 0, length - 1);

        }


        private void reverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        #endregion

        #region move zeros to the end
        internal void MoveZeroToTheEnd(int[] arr)
        {
            int i = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {
                    if (i != j)
                    {
                        arr[i] = arr[j];
                        arr[j] = 0;
                    }
                    i++;
                }
            }
        }
        #endregion

        #region union of array
        public void UnionOfArray(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                if (!set.Contains(arr1[i]))
                {
                    set.Add(arr1[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (!set.Contains(arr2[i]))
                {
                    set.Add(arr2[i]);
                }
            }

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
        }

        //when arrays are sorted
        public void UnionOfArraysByTwoPointer(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            int i = 0, j = 0;
            HashSet<int> set = new HashSet<int>();
            while (i < m && j < n)
            {
                if (arr1[i] <= arr2[j])
                {
                    if (!set.Contains(arr1[i]))
                    {
                        set.Add(arr1[i]);
                    }
                    i++;
                }
                else
                {
                    if (!set.Contains(arr2[j]))
                    {
                        set.Add(arr2[j]);
                    }
                    j++;
                }
            }

            while (i < m)
            {
                if (!set.Contains(arr1[i]))
                {
                    set.Add(arr1[i]);
                }
                i++;
            }
            while (j < n)
            {
                if (!set.Contains(arr2[j]))
                {
                    set.Add(arr2[j]);
                }
                j++;
            }

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
        }
        #endregion

        #region missing number
        internal void MissingAndEtraNumber(int[] a)
        {
            int[] temp = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                temp[a[i]]++;
            }
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == 0 || temp[i] > 1)
                {
                    Console.WriteLine(temp[i]);
                }
            }
        }

        internal int MissingNumber(int[] a)
        {
            int xor1 = a[0];
            int xor2 = 1;
            for (int i = 1; i < a.Length; i++)
            {
                xor1 ^= a[i];
            }
            for (int i = 2; i <= a.Length + 1; i++)
            {
                xor2 ^= i;
            }
            return xor1 ^ xor2;
        }

        internal int MissingNumberUsingSum(int[] a)
        {
            int total = 1;
            for (int i = 2; i < a.Length; i++)
            {
                total += i;
                total -= a[i - 2];
            }
            return total;
        }

        /// <summary>
        /// all number are twice except one find that one
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
        #endregion

        #region maximum ones in array
        public int MaxOnesInArray(int[] a)
        {
            int count = 0, max = 0;

            for (int i = 0; i < a.Length; i++)
            {
                count = a[i] != 0 ? count + 1 : 0;
                max = Math.Max(max, count);
            }

            return max;
        }


        // k is maximum of number zeroes allowed to flip
        // n is size of array
        internal int findZeroes(int[] nums, int n, int k)
        {
            // code here
            int start = 0;
            int zeros = 0;
            int j = 0;

            for (; j < n; j++)
            {
                if (nums[j] == 0)
                    zeros++;
                if (zeros > k)
                {
                    if (nums[start] == 0)
                    {
                        zeros--;
                    }
                    start++;
                }
            }

            return j - start;

        }
        #endregion

        #region longest subarray with sum equal k

        //Brute force
        internal int LongestSubArrayWithSumK(int[] a, int k)
        {
            int sum = 0, maxLength = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                int j = i + 1;
                while (j < a.Length)
                {
                    sum += a[j];
                    if (sum >= k)
                    {
                        if (sum == k)
                            maxLength = Math.Max(j - i + 1, maxLength);
                        sum = 0;
                        break;
                    }
                    j++;
                }
            }
            return maxLength;
        }
        internal int longestSubArrayWithSum_optimal(int[] nums, int k)
        {
            int start = 0, end = -1, maxLength = 0, sum = 0;
            while (start < nums.Length)
            {
                while ((end + 1) < nums.Length && sum + (nums[end + 1]) <= k)
                    sum += nums[++end];
                if (sum == k)
                {
                    maxLength = Math.Max(end - start + 1, maxLength);
                }
                sum -= nums[start];
                start++;
            }
            return maxLength;
        }

        internal int MaxOfSubArray(int[] nums)
        {
            int currentSum = nums[0], bestSum = nums[0];
            int currentLength = 0, bestLength = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > currentSum + nums[i])
                {
                    currentSum = nums[i];
                    currentLength = 0;
                }
                else
                {
                    currentSum += nums[i];
                    currentLength++;
                }
                if (currentSum > bestSum)
                {
                    bestLength = currentLength;
                    bestSum = currentSum;
                }
            }
            return bestSum;

        }

        //Brute force
        internal int NumberOfSubArrayWithGivenSum(int[] nums, int k)
        {
            int sum = 0, count = 0, test = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (k == nums[i])
                {
                    count++;
                }

                sum += nums[i];
                int j = i + 1;
                while (j < nums.Length)
                {
                    test++;
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                    j++;
                }

                sum = 0;
            }
            Console.WriteLine(test);
            return count;
        }
        #endregion

        internal void SortArrayOfThreeValues(int[] a)
        {
            //1, 0, 0, 2, 2, 1, 0
            int start = 0;
            int mid = 0;
            int end = a.Length - 1;
            while (mid <= end)
            {
                if (a[mid] == 0)
                {
                    int temp = a[start];
                    a[start] = a[mid];
                    a[mid] = temp;
                    start++;
                    mid++;
                }
                else if (a[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = a[mid];
                    a[mid] = a[end];
                    a[end] = temp;
                    end--;
                }
            }
        }

    }
}

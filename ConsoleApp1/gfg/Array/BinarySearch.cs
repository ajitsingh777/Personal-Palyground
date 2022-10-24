using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Array
{
    internal class BinarySearch
    {
        internal int FindFirstElement_Recurrsion(int[] arr, int startIndex, int endIndex, int num)
        {
            if (startIndex > endIndex)
            {
                return -1;
            }
            int mid = startIndex + (endIndex - startIndex) / 2;
            if (arr[mid] == num)
            {
                if (mid == 0 || arr[mid] != arr[mid - 1])
                {
                    return mid;
                }
                return FindFirstElement_Recurrsion(arr, startIndex, mid - 1, num);

            }
            else if (arr[mid] > num)
            {
                return FindFirstElement_Recurrsion(arr, startIndex, mid - 1, num);
            }
            else
            {
                return FindFirstElement_Recurrsion(arr, mid + 1, endIndex, num);
            }
        }

        internal int FindFirstElement(int[] arr, int number)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] < number)
                {
                    start = mid + 1;
                }
                else if (arr[mid] > number)
                {
                    end = mid - 1;
                }
                else
                {
                    if (mid == 0 || arr[mid] != arr[mid - 1])
                    {
                        return mid;
                    }
                    end = mid - 1;
                }
            }
            return -1;
        }

        internal int FindLastOccurenceOfElement(int[] arr, int number)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] < number)
                {
                    start = mid + 1;
                }
                else if (arr[mid] > number)
                {
                    end = mid - 1;
                }
                else
                {
                    if (mid == arr.Length - 1 || arr[mid] != arr[mid + 1])
                    {
                        return mid;
                    }
                    start = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// count total occurence of element
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        internal int CountOccurenceOfElement(int[] arr, int n)
        {
            int firstOccurence = FindFirstElement(arr, n);
            if (firstOccurence == -1)
            {
                return 0;
            }
            else
            {
                return FindLastOccurenceOfElement(arr, n) - firstOccurence + 1;
            }
        }

        /// <summary>
        /// take start as 1 and end as n
        /// check if square of mid equal to n it means mid is square root of x
        /// if square of mid less than n we will store mid in ans and then check if there is bigger number whose square is bigger than ans
        /// as 2*2 <10 and 3*3 <10 so squre root will be 3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        internal int SquareRoot(int n)
        {
            int start = 1, end = n, ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int squre = mid * mid;
                if (squre == n)
                {
                    return mid;
                }
                if (squre > n)
                {
                    end = mid - 1;
                }
                else if (squre < n)
                {
                    ans = mid;
                    start = mid + 1;
                }
            }
            return ans;
        }

        /// <summary>
        /// Infinite size means size is very very big and element is available in left side of array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        internal int SearchInInfiniteSizeArray(int[] arr, int num)
        {
            ///explictly compare 0th index element with nums becase when we will double the index 0*2 will be 0
            if (arr[0] == num)
            {
                return 0;
            }
            int i = 1;
            while (arr[i] < num)
            {
                i *= 2;
            }
            if (arr[i] == num)
            {
                return i;
            }
            /// once ith index is greater than given number we found the upper bound we will use binary search now 
            return FindFirstElement_Recurrsion(arr, i / 2 + 1, i, num);
        }

        /// <summary>
        /// concept is there will always one half of array be sorted
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        internal int SearchInRotatedSortedArray(int[] arr, int x)
        {
            int start = 0, end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }
                /// check if left half is sorted by comparing first element with mid element
                /// and if x is in this range search in this half otherwise search in second half
                else if (arr[start] < arr[mid])
                {
                    if (x >= arr[start] && x < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                ///if right half is sorted check if x in the range of this half than seach in this half otherwise in left half
                else
                {
                    if (x > arr[mid] && x <= arr[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return -1;
        }

        internal bool PairWithGivenSum(int[] arr, int sum)
        {
            int start = 0, end = arr.Length - 1;

            while (start < end)
            {
                if (sum == arr[start] + arr[end])
                {
                    return true;
                }
                else if (sum > arr[start] + arr[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return false;
        }

        internal bool TripletWithGivenSum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                int remainder = sum - arr[i];
                int start = i + 1;
                int end = arr.Length - 1;
                while (start < end)
                {
                    if (remainder == arr[start] + arr[end])
                    {
                        return true;
                    }
                    else if (remainder > arr[start] + arr[end])
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// it works on the concept of every independent array have at least one peak element
        /// we check if left element is bigger than mid than check in left array
        /// otherwise check in right array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int peakElement(int[] arr, int n)
        {
            if (n == 1 || arr[0] > arr[1])
            {
                return 0;
            }
            if (arr[n - 1] > arr[n - 2])
            {
                return n - 1;
            }
            int start = 1, end = n - 2;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] >= arr[mid - 1] && arr[mid] >= arr[mid + 1])
                {
                    return mid;
                }
                else if (arr[mid - 1] > arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        public long findFloor(long[] arr, long n, long x)
        {
            long start = 0, end = n - 1, floor = -1;

            while (start <= end)
            {
                long mid = start + (end - start) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] > x)
                {
                    end = mid - 1;
                }
                else
                {
                    floor = mid;
                    start = mid + 1;
                }
            }

            return floor;
        }

        public int countOccurence(int[] arr, int n, int k)
        {
            Dictionary<int, int> occurence = new Dictionary<int, int>();
            int thresold = n / k;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (occurence.ContainsKey(arr[i]))
                {
                    occurence[arr[i]]++;
                }
                else
                {
                    occurence[arr[i]] = 1;
                }
            }

            foreach (var item in occurence)
            {
                if (item.Value > thresold)
                    count++;
            }
            return count;
        }

        public int majorityElement(int[] a, int size)
        {
            int count = 0, majorityElem = 0;
            for (int i = 0; i < size; i++)
            {
                if (count == 0)
                {
                    majorityElem = a[i];
                }
                count += majorityElem == a[i] ? 1 : -1;
            }
            count = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] == majorityElem)
                    count++;
            }
            return count > size / 2 ? majorityElem : -1;
        }

        public List<int> twoRepeated(int[] a, int n)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                int index = Math.Abs(a[i]);
                if (a[index] > 0)
                {
                    a[index] = -a[index];
                }
                else
                {
                    result.Add(index);
                }
            }
            return result;
        }

        //Function to find the minimum element in sorted and rotated array.
        public int minNumber(int[] arr, int low, int high)
        {
            int min = Int32.MaxValue;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                min = Math.Min(min, arr[mid]);
                if (arr[mid] >= arr[low])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return min;
        }

        //Function to find maximum number of consecutive steps 
        //to gain an increase in altitude with each step.
        public int maxStep(int[] arr, int n)
        {
            int maxSteps = 0;
            int currentSteps = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    currentSteps++;
                }
                else
                {
                    currentSteps = 0;
                }
                maxSteps = Math.Max(maxSteps, currentSteps);
            }
            return maxSteps;
        }

        //Function to find a continuous sub-array which adds up to a given number.
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            if (s == 0)
            {
                return new List<int>() { -1 };
            }
            int currentSum = 0, start = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                while (currentSum > s)
                {
                    currentSum -= arr[start++];
                }
                if (currentSum == s)
                {
                    return new List<int>() { start + 1, i + 1 };
                }
            }
            return new List<int>() { -1 };
        }

        //Function to return the maximum water that can be stored.
        public int maxWater(int[] height, int n)
        {
            int start = 0, end = n - 1;
            int maxStoredWater = 0;
            while (start < end)
            {
                int minHeight = Math.Min(height[start], height[end]);
                maxStoredWater = Math.Max(maxStoredWater, minHeight * (end - start - 1));
                if (height[start] < height[end])
                {
                    start++;
                }
                else { end--; }
            }
            return maxStoredWater;
        }

        //Function to find the smallest positive number missing from the array.
        public int MissingNumber(int[] arr, int n)
        {
            /// shift all positive to the right and return their first index
            int shift = SegregateArray(arr, n);

            ///create array from postive number and fill be postive number
            int[] A = new int[n - shift];
            ShiftArray(arr, A, shift, n);
            return FindSmallestMissingPositiveNumber(A);
        }

        public int FindSmallestMissingPositiveNumber(int[] array)
        {
            ///mark all numbers before missing number as negative
            for (int i = 0; i < array.Length; i++)
            {
                ///index start from zero and postive number start from 1 so sutracted 1
                int index = Math.Abs(array[i]) - 1;

                ///check if this index is less than size
                ///there can be chances if this number is bigger than size than it will be out of index
                if (index < array.Length && array[index] > 0)
                {
                    array[index] = -array[index];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    return i + 1;
                }
            }
            return array.Length + 1;
        }
        public int SegregateArray(int[] arr, int n)
        {
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            return j;
        }

        public void ShiftArray(int[] arr, int[] A, int shift, int n)
        {
            int k = 0;

            for (int i = shift; i < n; i++)
            {
                A[k++] = arr[i];
            }
        }

        /// <summary>
        /// numbers are 1 to n-1 and there is only one repeating element
        /// Typical hair tortoise problem
        /// slow runs one element per iteration and fast with double speed
        /// at some point they will meet at some point
        /// claim is they are of equal distance from begining and cycle element
        /// so set slow to arr[0] now at same speed they will meet at cycle(repeating) element
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindRepeatingElement(int[] arr, int n)
        {
            int slow = arr[0], fast = arr[0];
            do
            {
                slow = arr[slow];
                fast = arr[arr[fast]];
            } while (slow != fast);

            slow = arr[0];
            while (slow != fast)
            {
                slow = arr[slow];
                fast = arr[fast];
            }
            return slow;
        }

        //Function to find repeated element and its frequency in consuctive sorted array.
        public List<int> FindRepeating(int[] arr, int n)
        {
            /// as it's consuective numbers so it's frequency will be
            /// lenth of array - last element + first element 
            /// if no repeating element then last eleemnt equal to first element + length
            int frequency = n - (arr[n - 1] - arr[0]);
            if (frequency == 0)
            {
                return new List<int>() { -1, -1 };
            }
            int start = 0, end = n - 1;
            while (start <= end)
            {

                int mid = start + (end - start) / 2;
                if (arr[mid] == arr[mid - 1] || arr[mid] == arr[mid + 1])
                {
                    return new List<int>() { arr[mid], frequency };
                }
                ///if there is not repeating element in first half then below 
                ///condition will be true
                if (arr[mid] - arr[start] == mid - start)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return new List<int> { -1, -1 };
        }

        //Function to find minimum number of pages.
        public int findPages(int[] A, int N, int M)
        {
            int sumOfPages = 0;
            int maxPages = A[0];
            int result = -1;

            ///if number of books less than student then 
            ///all student will not be able to read at least one book
            if (N < M)
            {
                return -1;
            }

            for (int i = 0; i < N; i++)
            {
                sumOfPages += A[i];
                maxPages = Math.Max(maxPages, A[i]);
            }

            /// number of pages will be between max pages in book an ssum of pages
            /// because we can't divide books to multiple student
            int low = maxPages, high = sumOfPages;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (isValidDivisionOfPages(A, mid, M))
                {
                    result = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return result;
        }

        public bool isValidDivisionOfPages(int[] arr, int pages, int students)
        {
            int reader = 1;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] + sum > pages)
                {
                    reader++;
                    sum = arr[i];
                }
                else
                {
                    sum += arr[i];
                }
            }
            return reader <= students;
        }

        //Function to find the median of the two arrays when they get merged.
        public int findMedian(int[] arr, int n, int[] brr, int m)
        {
            /// first array length should be smaller or equal to second array
            /// switch thme if it's bigger
            if (n > m)
            {
                return findMedian(brr, m, arr, n);
            }

            int start = 0, end = n;
            while (start <= end)
            {
                /// we will apply binary search on first array
                int mid1 = start + (end - start) / 2;

                /// this is the formula to calculate mid of second array based on first array so overall mid will be
                /// taken care
                int mid2 = (n + m + 1) / 2 - mid1;

                ///left element (before mid1) in first array
                int l1 = mid1 == 0 ? Int32.MinValue : arr[mid1 - 1];
                ///left element (before mid2) in second array
                int l2 = mid2 == 0 ? Int32.MinValue : brr[mid2 - 1];

                ///right element (mid1) in first array
                int r1 = mid1 == n ? Int32.MaxValue : arr[mid1];

                ///right element (mid1) in second array
                int r2 = mid2 == m ? Int32.MaxValue : brr[mid2];

                /// if that's true it means we are at median of two array
                if (l1 <= r2 && l2 <= r1)
                {
                    if ((n + m) % 2 == 0)
                    {
                        return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2;
                    }
                    else
                    {
                        return Math.Max(l1, l2);
                    }
                }
                /// if l1 is bigger than r2 we need to go left part of first aary
                else if (l1 > r2)
                {
                    end = mid1 - 1;
                }
                else
                {
                    start = mid1 + 1;
                }
            }
            return 0;
        }
    }
}

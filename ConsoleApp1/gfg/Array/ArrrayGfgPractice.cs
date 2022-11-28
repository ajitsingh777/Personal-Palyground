using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Array
{
    internal class ArrrayGfgPractice
    {

        internal int RemoveDuplicateFromSortedArray_approach2(int[] arr)
        {
            int start = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[start] != arr[i])
                {
                    start++;
                    arr[start] = arr[i];
                }
            }

            // add +1 as it's zero based index
            return start + 1;
        }

        internal void MoveZeroesAtTheEnd(int[] arr)
        {
            int nonZeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[nonZeroCount];
                    arr[nonZeroCount] = temp;
                    nonZeroCount++;
                }
            }
        }

        /// <summary>
        /// given a list of stock price on different day
        /// buy a stock on multiple occasion and sell as many time you want and get max profit
        /// [1,5,3,2,8,12]
        /// buy at dip and sell at top
        /// buy at 1 and sell at 5 ,profit will be 4
        /// wait for next dip as till 2
        /// now buy at 2 and you will get profit for 8(8-2) and for 12 (12-8)
        /// so total profit will be 4 + 6 + 4
        /// </summary>
        /// <param name="stockPrices"></param>
        /// <returns></returns>
        internal int BuyAndSellStocks(int[] stockPrices)
        {
            int profit = 0;

            for (int i = 1; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] > stockPrices[i - 1])
                {
                    profit += stockPrices[i] - stockPrices[i - 1];
                }
            }
            return profit;
        }

        internal int TrappingRainWater(int[] arr)
        {
            int n = arr.Length;
            int result = 0;
            int[] maxLeft = new int[n];
            int[] maxRight = new int[n];

            ///calculate max left for every element
            ///for first element max value will be itself
            ///and for other element it will be max of maxleft and that element
            maxLeft[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                maxLeft[i] = Math.Max(maxLeft[i - 1], arr[i]);
            }

            ///calculate maxRight for every element
            ///for last element it will be itself
            maxRight[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                maxRight[i] = Math.Max(maxRight[i + 1], arr[i]);
            }

            ///calculate the storage capacity
            ///min for leftMax and leftRigth and then sutract that element
            for (int i = 1; i < n - 1; i++)
            {
                result += Math.Min(maxRight[i], maxLeft[i]) - arr[i];
            }
            return result;
        }

        internal int MaxSubArraySum(int[] arr)
        {
            int currentSum = int.MinValue, bestSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                /// if current element is greater that currentSum + element then start a new subarray with current element
                /// and intialize currentSum with current element other wise add element to currentSum
                currentSum = Math.Max(arr[i], currentSum + arr[i]);

                ///check if current subarray sum is bestSum and update it
                bestSum = Math.Max(currentSum, bestSum);
            }
            return bestSum;
        }

        internal int LongestEvenOddSequence(int[] arr)
        {
            int maxSequence = 1, currentSequence = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 2 == 0 && arr[i + 1] % 2 != 0) || (arr[i] % 2 != 0 && arr[i + 1] % 2 == 0))
                {
                    currentSequence++;
                    maxSequence = Math.Max(maxSequence, currentSequence);
                }
                else
                {
                    currentSequence = 1;
                }
            }
            return maxSequence;
        }
        internal int MajorityElement(int[] arr)
        {
            int count = 0, majorityElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    majorityElement = arr[i];
                }
                count += majorityElement == arr[i] ? 1 : -1;
            }
            return majorityElement;
        }

        internal int MaxSumOfSubArrayWithKElements(int[] arr, int k)
        {
            int currentSum = 0, maxSum;

            ///calculate sum for first window of k elements
            for (int i = 0; i < k; i++)
            {
                currentSum += arr[i];
            }
            maxSum = currentSum;

            /// a
            for (int i = k; i < arr.Length; i++)
            {
                ///
                currentSum = currentSum - arr[i - k] + arr[i];

                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        internal bool SubArrayWithGivenSum(int[] arr, int sum)
        {
            int currentSum = 0, start = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                while (currentSum > sum)
                {
                    currentSum -= arr[start++];
                }
                if (currentSum == sum)
                {
                    return true;
                }
            }
            return false;
        }
        internal bool IsEquilibrium(int[] arr)
        {
            int total_sum = 0, left_sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total_sum += arr[i];
            }
            /// total_sum - left_sum will be right_sum 
            /// at any element if right_sum equal to left_sum than it's equilibrium point
            for (int i = 0; i < arr.Length; i++)
            {
                if (left_sum == total_sum - arr[i])
                {
                    Console.WriteLine($"{arr[i]} is Equilibriul point");
                    return true;
                }
                left_sum += arr[i];
                total_sum -= arr[i];
            }
            return false;
        }

        public void largestAndSecondLargest(int[] A, int N)
        {
            int max = int.MinValue;
            int secondMax = -1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            Console.WriteLine(max + " " + secondMax);
        }

        public void reverseInGroups(int[] A, int N, int k)
        {
            for (int i = 0; i < N; i += k)
            {
                if (i + k > N - 1)
                {
                    ReverseArray(A, i, N - 1);
                }
                else
                {
                    ReverseArray(A, i, i + k - 1);
                }

            }
        }

        public void ReverseArray(int[] arr, int start, int end)
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

        /// <summary>
        /// Given an array Arr of n integers arranged in a circular fashion. Your task is 
        /// to find the minimum absolute difference between adjacent elements.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int minAdjDiff(int[] arr, int n)
        {
            int min_difference = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int absDifference = Math.Abs(arr[i] - arr[i + 1]);
                min_difference = Math.Min(absDifference, min_difference);
            }
            int circulardiff = Math.Abs(arr[n - 1] - arr[0]);
            min_difference = Math.Min(circulardiff, min_difference);
            return min_difference;
        }

        /// <summary>
        /// {1,2,3,4,5}
        /// </summary>
        /// <param name="n"></param>
        /// <param name="arr"></param>
        public void ConvertToWave(int n, int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

        }
        public void frequencyCount(int[] arr, int N, int P)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (counts.ContainsKey(arr[i]))
                {
                    counts[arr[i]]++;
                }
                else
                {
                    counts[arr[i]] = 1;
                }
            }
            for (int i = 1; i <= N; i++)
            {
                if (counts.ContainsKey(i))
                {
                    arr[i - 1] = counts[i];
                }
                else
                {
                    arr[i - 1] = 0;
                }
            }
        }

        public int[] leaders(int[] arr, int N)
        {
            List<int> list = new List<int>();
            list.Add(arr[N - 1]);
            int current_leader = arr[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                if (arr[i] > current_leader)
                {
                    list.Insert(0, arr[i]);
                    current_leader = arr[i];
                }
            }

            return list.ToArray();
        }

        public long maxSubarraySum(int[] arr, int n)
        {
            int current_sum = Int32.MinValue, max_sum = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                current_sum = Math.Max(current_sum + arr[i], arr[i]);
                max_sum = Math.Max(current_sum, max_sum);
            }
            return max_sum;
        }

        /// <summary>
        /// WLWLLWLLWWLWWW
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public int betBalance(string result)
        {
            int intial_sum = 4, bet_amount = 1;

            for (int i = 0; i < result.Length; i++)
            {
                if (intial_sum < bet_amount)
                {
                    return -1;
                }
                if (result[i] == 'W')
                {
                    intial_sum += bet_amount;
                    bet_amount = 1;
                }
                else
                {
                    intial_sum -= bet_amount;
                    bet_amount *= 2;
                }
            }
            return intial_sum;
        }

        /// <summary>
        ///  L and R are input array
        /// maxx : maximum in R[]
        /// n: size of array
        /// arr[] : declared globally with size equal to maximum in L[] and R[]
        /// Function to find the maximum occurred integer in all ranges.
        /// </summary>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <param name="n"></param>
        /// <param name="maxx"></param>
        /// <returns></returns>
        public int maxOccured(int[] L, int[] R, int n, int maxx)
        {
            /// create a list with the capacity of maxx element in R
            int[] list = new int[maxx + 2];

            /// increase the L[i] (starting element of range) element by 1
            for (int i = 0; i < n; i++)
            {
                list[L[i]]++;

                ///make next element to range as -1 to re calculate the pre sum as 0
                list[R[i] + 1]--;
            }
            int max = list[0];
            int result = 0;

            /// calculate pre sum of element
            /// if L[i] =1 then all element in this range will be 0+1 = 1
            /// so if 5 coming in two ranges (1,5) and (2,7) then it will be 1+1 two
            for (int i = 1; i <= maxx; i++)
            {
                list[i] += list[i - 1];
                if (max < list[i])
                {
                    max = list[i];
                    result = i;
                }
            }
            return result;
        }

        public List<List<int>> stockBuySell(int[] A, int n)
        {
            List<List<int>> list = new List<List<int>>();
            int lowIndex = 0, highIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i] > A[i - 1])
                {
                    highIndex = i;
                }
                else
                {
                    if (highIndex > 0)
                    {
                        list.Add(new List<int> { lowIndex, highIndex });
                        highIndex = 0;
                    }
                    lowIndex = i;
                }
            }
            if (highIndex > 0)
            {
                list.Add(new List<int> { lowIndex, highIndex });
            }

            return list;
        }

        public long trappingWater(int[] arr, int n)
        {
            int[] left_max_pillar = new int[n];
            int[] right_max_pillar = new int[n];
            long total_water = 0;

            left_max_pillar[0] = arr[0];

            for (int i = 1; i < n; i++)
            {
                left_max_pillar[i] = Math.Max(left_max_pillar[i - 1], arr[i]);
            }

            right_max_pillar[n - 1] = arr[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                right_max_pillar[i] = Math.Max(right_max_pillar[i + 1], arr[i]);
            }

            for (int i = 0; i < n; i++)
            {
                total_water += Math.Min(left_max_pillar[i], right_max_pillar[i]) - arr[i];
            }

            return total_water;
        }

        public int missingNumber(int[] arr, int n)
        {
            HashSet<int> set = new HashSet<int>();

            for (int k = 0; k < n; k++)
            {
                if (arr[k] > 0 && !set.Contains(arr[k]))
                {
                    set.Add(arr[k]);
                }
            }
            int i = 1;
            for (; i <= set.Count + 1; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }
            return i;
        }

        /// <summary>
        /// {1,2,3,4,5,6}
        /// at zero position 1+ 6%7 *7 =43
        /// to get one back second position 2 + 43%7 * 7 = 9 and 9/7 =1 
        /// 9/7 =1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public void rearrange(long[] arr, int n)
        {
            int min_idx = 0, max_idx = n - 1;
            ///all values will be smaller than this
            long constant = arr[n - 1] + 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] += (arr[max_idx] % constant) * constant;
                    max_idx--;
                }
                else
                {
                    arr[i] += (arr[min_idx] % constant) * constant;
                    min_idx++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] /= constant;
            }
        }

        public void arrange(int[] arr, int n)
        {
            int constant = n;
            for (int i = 0; i < n; i++)
            {
                /// every element is 0 to n-1 so will use constant as n
                /// check above problem
                arr[i] += (arr[arr[i]] % constant) * constant;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] /= constant;
            }
        }

        /// <summary>
        /// Input: N = 16
        /// Output: 16 11 6 1 -4 1 6 11 16
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public List<int> pattern(int N)
        {
            List<int> list = new List<int>();
            CreatePattern(N, list);
            return list;
        }

        public void CreatePattern(int N, List<int> list)
        {
            if (N < 0)
            {
                list.Add(N);
                return;
            }
            list.Add(N);
            CreatePattern(N - 5, list);
            list.Add(N);
        }

        public int maxEvenOdd(int[] arr, int n)
        {
            int current_sequence = 1, max_sequence = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if ((arr[i] % 2 == 0 && arr[i + 1] % 2 != 0) || (arr[i] % 2 != 0 && arr[i + 1] % 2 == 0))
                {
                    current_sequence++;
                    max_sequence = Math.Max(max_sequence, current_sequence);
                }
                else
                {
                    current_sequence = 1;
                }
            }

            return max_sequence;
        }

        public bool checkRotatedAndSorted(int[] arr, int n)
        {
            int count = 0;
            if (arr[0] > arr[n - 1])
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        count++;
                        if (count > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        count++;
                        if (count > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return count == 1;
        }

        /// <summary>
        /// Naive approach
        /// </summary>
        /// <param name="A"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public int maxIndexDiff(int[] A, int N)
        {
            int maxDiff = 0;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] <= A[j])
                    {
                        maxDiff = Math.Max(maxDiff, j - i);
                    }
                }
            }
            return maxDiff;
        }

        public int maxIndexDiff_optimal(int[] A, int N)
        {
            int[] left_min = new int[N];
            int[] right_max = new int[N];

            left_min[0] = A[0];
            for (int i = 1; i < N; i++)
            {
                left_min[i] = Math.Min(A[i], left_min[i - 1]);
            }
            right_max[N - 1] = A[N - 1];
            for (int i = N - 2; i >= 0; i--)
            {
                right_max[i] = Math.Max(A[i], right_max[i + 1]);
            }
            int j = 0;
            int current_max = -1;
            for (int i = 0; i < N; i++)
            {

                while (j < N && left_min[i] <= right_max[j])
                {
                    j++;
                }
                current_max = Math.Max(current_max, j - i - 1);

            }
            return current_max;
        }

        public long numGame(long n)
        {
            if (n <= 2)
            {
                return n;
            }
            long result = 1;
            for (long i = 1; i <= n; i++)
            {
                long gcd = GCD(i, result);
                result = (result * i / gcd) % 1000000007;
            }
            return result;
        }

        public long GCD(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Arrays/video/NzAyMw%3D%3D
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaximumSubArraySumWithLengthK(int[] arr, int k)
        {
            int current_sum = 0, max_Sum = 0;
            int i = 0;
            for (; i < k; i++)
            {
                current_sum += arr[i];
            }
            max_Sum = current_sum;
            for (; i < arr.Length; i++)
            {
                current_sum = current_sum - arr[i - k] + arr[i];
                max_Sum = Math.Max(current_sum, max_Sum);
            }
            return max_Sum;
        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Arrays/video/NzAyNA%3D%3D
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool SubArrayWithGivenSum2(int[] arr, int sum)
        {
            int curr_Sum = 0; int prev = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                curr_Sum += arr[i];
                while (prev < arr.Length && curr_Sum > sum)
                {
                    curr_Sum -= arr[prev++];
                }

                if (curr_Sum == sum)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

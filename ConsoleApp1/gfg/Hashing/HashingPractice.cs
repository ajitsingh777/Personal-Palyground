﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DSPractice.gfg.Hashing
{
    internal class HashingPractice
    {

        //Complete this function
        //Function to insert elements of array in the hashTable avoiding collisions.
        public List<List<int>> separateChaining(int hashSize, int[] arr)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < hashSize; i++)
            {
                result.Add(new List<int>());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i] % hashSize;
                result[key].Add(arr[i]);
            }
            return result;
        }

        //Complete this function
        //Function to return the count of non-repeated elements in the array.
        public List<int> countNonRepeated(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (result.ContainsKey(arr[i]))
                {
                    result[arr[i]]++;
                }
                else
                {
                    result.Add(arr[i], 1);
                }
            }

            return result.Where(x => x.Value == 1).Select(x => x.Key).ToList();

        }

        /// <summary>
        /// Prefix sum with Hashing
        /// at any point if prefix sum is equal to previous prefix sume it means 
        /// that sub array is not adding anything in prefix sum , so it's sum is zero
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool SubArrayWitSumZero(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            int prefixSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];
                if (set.Contains(prefixSum))
                {
                    return true;
                }
                if (prefixSum == 0)
                {
                    return true;
                }
                set.Add(prefixSum);

            }
            return false;
        }

        /// <summary>
        /// Prefix sum with Hashing
        /// at any point if prefix sum - given sum  is equal to previous prefix sum it means 
        /// that sub array is having sum equal to given sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool SubArrayWithGivenSum(int[] arr, int sum)
        {
            HashSet<int> set = new HashSet<int>();
            int prefixSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];
                if (prefixSum == sum)
                {
                    return true;
                }
                if (set.Contains(prefixSum - sum))
                {
                    return true;
                }
                set.Add(prefixSum);

            }
            return false;
        }

        // Function to return the position of the first repeating element.
        public int FirstRepeated(int[] arr, int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (dict[arr[i]] > 1)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        // Function to return the count of the number of elements in
        // the intersection of two arrays.
        public int NumberofElementsInIntersection(int[] a, int[] b, int n, int m)
        {
            int count = 0;
            HashSet<int> set = new HashSet<int>();
            if (n <= m)
            {
                for (int i = 0; i < n; i++)
                {
                    set.Add(a[i]);
                }
                for (int i = 0; i < m; i++)
                {
                    if (set.Contains(b[i]))
                    {
                        count++;
                        set.Remove(b[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    set.Add(b[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    if (set.Contains(a[i]))
                    {
                        count++;
                        set.Remove(a[i]);
                    }
                }
            }
            return count;
        }

        //Function to return the count of the number of elements in
        //the intersection of two arrays.
        public int doUnion(int[] a, int[] b, int n, int m)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set.Add(a[i]);
            }
            for (int i = 0; i < m; i++)
            {
                set.Add(b[i]);
            }
            return set.Count;
        }

        // Complete this function
        // Function to check if there is a pair with the given sum in the array.
        public int sumExists(int[] arr, int N, int sum)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                if (set.Contains(sum - arr[i]))
                {
                    return 1;
                }
                set.Add(arr[i]);
            }
            return 0;
        }

        //Function to return the count of the number of elements in
        //the intersection of two arrays.
        public bool check(long[] A, long[] B, int n)
        {
            Dictionary<long, int> set = new Dictionary<long, int>();

            for (int i = 0; i < n; i++)
            {
                if (set.ContainsKey(A[i]))
                {
                    set[A[i]]++;
                }
                else
                {
                    set[A[i]] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int value;
                bool exist = set.TryGetValue(B[i], out value);
                if (!exist)
                {
                    return false;
                }

                else if (value == 1)
                {
                    set.Remove(B[i]);

                }
                else
                {
                    set[B[i]]--;
                }
            }

            return set.Count == 0;
        }

        //Function to return list containing all the pairs having both
        //negative and positive values of a number in the array.
        public List<int> findPairs(int[] arr, int n)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (set.Contains(-arr[i]))
                {
                    list.Add(-arr[i]);
                    list.Add(arr[i]);
                    set.Remove(-arr[i]);
                }
            }
            return list;
        }

        //Complete this function
        //Function to check whether there is a subarray present with 0-sum or not.
        public bool subArrayExists(int[] arr, int n)
        {
            HashSet<int> set = new HashSet<int>();
            if (arr[0] == 0)
            {
                return true;
            }
            int preSum = 0;
            for (int i = 0; i < n; i++)
            {
                preSum = preSum + arr[i];
                if (set.Contains(preSum))
                {
                    return true;
                }
                else
                {
                    set.Add(preSum);
                }
            }
            return false;
        }

        //Function to return the name of candidate that received maximum votes.
        public List<string> winner(string[] arr, int n)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                if (votes.ContainsKey(arr[i]))
                {
                    votes[arr[i]]++;
                }
                else
                {
                    votes[arr[i]] = 1;
                }
            }
            string name = "";
            int vote = 0;
            foreach (var item in votes)
            {

                if (item.Value > vote)
                {
                    name = item.Key;
                    vote = item.Value;
                }
                if (item.Value == vote)
                {
                    if (string.Compare(name, item.Key) > 0)
                    {
                        name = item.Key;
                        vote = item.Value;
                    }
                }
            }

            return new List<string>() { name, vote.ToString() };
        }

        public int LargestSubArrayWithGivenSum(int[] arr, int sum, int n)
        {
            int length = -1;
            int prefixSum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                prefixSum += arr[i];
                if (prefixSum == sum)
                {
                    length = Math.Max(length, i + 1);
                }
                if (!dict.ContainsKey(prefixSum))
                {
                    dict.Add(prefixSum, i);
                }
                if (dict.ContainsKey(prefixSum - sum))
                {
                    length = Math.Max(length, i - dict[prefixSum - sum]);
                }
            }

            return length;
        }

        //Function to return the name of candidate that received maximum votes.
        //Function to count the number of subarrays which adds to the given sum.
        public int subArraySum(int[] arr, int n, int sum)
        {
            int preSum = 0;
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                preSum += arr[i];

                /// if a sub array starting fro 0 index equal to sum then add it to count
                if (preSum == sum)
                {
                    count++;
                }
                /// presum -x =sum
                /// x = presum- sum
                ///  there is a subarray that if we remove from the presum then it will be equal to sum
                ///  so we will increase the count by number of this type of array
                if (map.ContainsKey(preSum - sum))
                {
                    count += map[preSum - sum];
                }
                if (map.ContainsKey(preSum))
                {
                    map[preSum]++;
                }
                else
                {
                    map[preSum] = 1;
                }

            }
            return count;
        }

        public int LongestCommonSubSequence(int[] arr)
        {
            int result = 1;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }

            foreach (int item in set)
            {
                if (!set.Contains(item - 1))
                {
                    int count = 1;
                    while (set.Contains(item + count))
                    {
                        count++;
                    }
                    result = Math.Max(result, count);
                }
            }

            return result;
        }

        //Function to count subarrays with sum equal to 0.
        public long findSubarray(long[] arr)
        {
            Dictionary<long, long> map = new Dictionary<long, long>();
            long count = 0;
            long prefixSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];
                if (prefixSum == 0)
                {
                    count++;
                }
                if (map.ContainsKey(prefixSum))
                {
                    count += map[prefixSum];
                    map[prefixSum]++;
                }
                else
                {
                    map[prefixSum] = 1;
                }
            }


            return count;
        }

        public int ToggleMiddleBit(int N)
        {
            int x = 0, lastSetBit = 0;
            int temp = N;

            while (temp > 0)
            {
                lastSetBit++;
                temp >>= 1;
            }
            int bitToSet = lastSetBit / 2;
            while (bitToSet > 0)
            {
                x = x << 1;
                bitToSet--;
            }
            if (lastSetBit % 2 == 0)
            {

                N = N ^ x;
                x = x << 1;
                N = N ^ x;

            }
            else
            {
                x = x << 1;
                N = N ^ x;
            }
            return N;
        }
    }
}

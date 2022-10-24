using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1.Array
{
    internal partial class ArrayPractice
    {
        internal int MaxProfitShares(int[] stocks)
        {
            int minPrice = int.MaxValue, maxProfit = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                minPrice = Math.Min(minPrice, stocks[i]);
                maxProfit = Math.Max(maxProfit, stocks[i] - minPrice);
            }
            return maxProfit;
        }

        /// <summary>
        /// Given an array, print all the elements which are leaders. 
        /// A Leader is an element that is greater than all of the elements on its right side in the array.
        /// </summary>
        /// <param name="nums"></param>
        internal void LeadersInArray(int[] nums)
        {
            int max = nums[nums.Length - 1];
            Console.Write(max + " ");
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    Console.Write(max + " ");
                }
            }
        }

        internal int LongestConsuectiveSequence(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            int maxStreak = 0;
            foreach (var item in nums)
            {
                if (!set.Contains(item - 1))
                {
                    int currentNumber = item;
                    int currentStreak = 1;
                    while (set.Contains(currentNumber + 1))
                    {
                        currentNumber++;
                        currentStreak++;
                    }
                    maxStreak = Math.Max(currentStreak, maxStreak);
                }

            }
            return maxStreak;
        }

        internal int[] RearrangeArray(int[] nums)
        {
            int posIndex = 0, negIndex = 1;
            int[] arranged = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    arranged[posIndex] = nums[i];
                    posIndex += 2;
                }
                else
                {
                    arranged[negIndex] = nums[i];
                    negIndex += 2;
                }
            }
            return arranged;
        }
        internal void PascalTriangel(int n)
        {
            List<List<int>> pascalTriangel = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(pascalTriangel[i - 1][j - 1] + pascalTriangel[i - 1][j]);
                    }
                }
                pascalTriangel.Add(list);
            }

            foreach (var item in pascalTriangel)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
        }

        internal void NextPremutation(int[] nums)
        {
            int pivot, i = nums.Length - 1, j = nums.Length - 1, greaterIndex;
            pivot = getPivot();
            if (pivot < 0)
            {
                while (i < j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            else
            {
                greaterIndex = LastIndexOfGreaterThanPivot();
                swap(pivot, greaterIndex);
                int k = pivot + 1;
                j = nums.Length - 1;
                while (k < j)
                {
                    swap(k, j);
                    k++;
                    j--;
                }
            }

            int getPivot()
            {
                while (i > 0 && nums[i] <= nums[i - 1])
                {
                    i--;
                }
                return i - 1;
            }

            int LastIndexOfGreaterThanPivot()
            {
                while (nums[pivot] >= nums[j])
                {
                    j--;
                }
                return j;
            }

            void swap(int pivot, int prefix)
            {
                int temp = nums[pivot];
                nums[pivot] = nums[prefix];
                nums[prefix] = temp;
            }
        }

        internal IList<IList<int>> ThreeSumTriplate(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int target = -nums[i];
                int front = i + 1;
                int back = nums.Length - 1;
                while (front < back)
                {
                    int sum = nums[front] + nums[back];
                    if (sum < target)
                    {
                        front++;
                    }
                    else if (sum > target)
                    {
                        back--;
                    }
                    else
                    {
                        List<int> temp = new List<int>() { nums[i], nums[front], nums[back] };
                        result.Add(temp);

                        while (front < back && nums[front] == temp[1])
                        {
                            front++;
                        }
                        while (back > front && nums[back] == nums[2])
                        {
                            back--;
                        }

                    }
                }
                while (i + 1 < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg.Re_practice
{
    internal class Practice
    {
        
        internal void PrintNToOne(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNToOne(n - 1);
        }
        internal void PrintOneToN(int n)
        {
            if (n == 0)
            {
                return;
            }
            PrintOneToN(n - 1);
            Console.WriteLine(n);
        }
        internal int NaturalNumbersSum(int n, int sum = 0)
        {
            if (n == 1)
            {
                return 1 + sum;
            }
            /// Tail recurssion
            return NaturalNumbersSum(n - 1, sum + n);
        }

        internal int SumOfDigits(int n, int sum = 0)
        {
            if (n <= 0)
            {
                return sum;
            }
            sum += n % 10;
            return SumOfDigits(n / 10, sum);
        }

        internal int RemoveDuplicateFromArray(int[] arr)
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

            return start + 1;
        }

        internal int MoveZeroesToTheEnd(int[] arr)
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
            return i - 1;
        }

        internal void PrintFreq(int[] arr)
        {
            int freq = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    Console.WriteLine($"{arr[i]} has freq {freq}");
                    freq = 1;
                }
                else
                {
                    freq++;
                }
            }
            Console.WriteLine($"{arr[arr.Length - 1]} has freq {freq}");
        }

        public void rearrange(long[] arr, int n)
        {
            long constant = arr[n - 1] + 1;
            int max_idx = n - 1;
            int min_idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = arr[i] + (arr[max_idx] % constant) * constant;
                    max_idx--;
                }
                else
                {
                    arr[i] = arr[i] + (arr[min_idx] % constant) * constant;
                    min_idx++;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] /= constant;
            }
        }
    }
}

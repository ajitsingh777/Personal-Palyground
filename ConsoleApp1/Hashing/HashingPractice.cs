using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hashing
{
    internal class HashingPractice
    {
        internal void CountFrequency(int[] arr)
        {
           Dictionary<int, int> freq = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freq.ContainsKey(arr[i]))
                {
                    freq[arr[i]]++;
                }
                else
                {
                    freq.Add(arr[i], 1);
                }
            }

            foreach (var item in freq.Keys)
            {
                Console.WriteLine($"{item} occurs {freq[item]} times");
            }
        }
    }
}

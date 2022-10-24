using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg
{
    internal class RecurssionPractice
    {
        internal void PrintNToOne(int n)
        {
            if (n == 0) { return; }
            Console.Write(n);
            PrintNToOne(n - 1);
        }

        internal void PrintOneToN(int n)
        {
            if (n == 0) { return; }
            PrintOneToN(n - 1);
            Console.Write(n);
        }

        internal int SumOfNNaturalNumbers(int n, int k = 0)
        {
            if (n == 1) { return 1 + k; }
            return SumOfNNaturalNumbers(n - 1, k + n);
        }

        internal bool isPalindrom(string str, int startIndex, int lastIndex)
        {
            if (startIndex >= lastIndex) { return true; }
            return str[startIndex] == str[lastIndex] && isPalindrom(str, startIndex + 1, lastIndex - 1);
        }

        internal int SumOfDigitOfNumber(int n)
        {
            if (n <= 0) { return 0; }
            return n % 10 + SumOfDigitOfNumber(n / 10);
        }

        internal int MaxPiecesOfRope(int n, int a, int b, int c)
        {
            if (n == 0) { return 0; }
            if (n < 0) { return -1; }
            int res1 = MaxPiecesOfRope(n - a, a, b, c);
            int res2 = MaxPiecesOfRope(n - b, a, b, c);
            int res3 = MaxPiecesOfRope(n - c, a, b, c);

            int res = Math.Max(Math.Max(res1, res2), res3);
            if (res < 0) { return -1; }
            return res + 1;
        }

        internal void SubsetsOfGivenStrings(string s, string current = "", int index = 0)
        {
            ArrayList l= new ArrayList();

            if (index == s.Length)
            {
                Console.WriteLine(current);
                return;
            }
            SubsetsOfGivenStrings(s, current, index + 1);
            SubsetsOfGivenStrings(s, current + s[index], index + 1);
        }

        internal int TowerOfHanoi(int n, char a, char b, char c, int moves = 0)
        {
            if (n >= 1)
            {
                moves += TowerOfHanoi(n - 1, a, c, b);
                Console.WriteLine($"move disk {n} from {a} to {c}");
                moves++;
                moves += TowerOfHanoi(n - 1, b, a, c);
            }
            return moves;
        }

        /// <summary>
        /// there are n persons in circle kill every kth person starting from 0 and pass the gun to k+1th person
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        internal int Josephus(int n, int k)
        {
            if (n == 1) //base case
                return 1;
            else

                return (((Josephus(n - 1, k) + k - 1) % n) + 1);
        }

        internal int SubsetSum(int[] arr, int n, int sum)
        {
            if (n == 0)
            {
                return sum == 0 ? 1 : 0;
            }
            return SubsetSum(arr, n - 1, sum) + SubsetSum(arr, n - 1, sum - arr[n - 1]);
        }

        internal int DigitalRoot(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return DigitalRoot(SumOfDigitOfNumber(n));
        }

        public long power(int n, int r)
        {
            if (r == 0)
            {
                return 1;
            }
            long y;
            if (r % 2 == 0)
            {
                y = power(n, r / 2);
                y = (y * y) % 1000000007;
            }
            else
            {
                y = n % 1000000007;
                y = (y * power(n, r - 1) % 1000000007) % 1000000007;
            }
            return ((y + 1000000007) % 1000000007);
        }
    }
}

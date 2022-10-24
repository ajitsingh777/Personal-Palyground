using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg
{
    internal class BitwiseOperator
    {
        internal void BitwiseOps(int a, int b)
        {
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
        }

        /// <summary>
        /// shift 1 to left by (k-1) and do & with n, id n's kth bit is 1 then only that bit be 1 other wise all bits be zero
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        internal void CheckIfKthBitIsSetWithLeftShift(int n, int k)
        {
            if ((n & (1 << (k - 1))) != 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        /// <summary>
        /// shift n to right by (k-1) then kth bit of k will be at right most and then compare it with 1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        internal void CheckIfKthBitIsSetWithRightShift(int n, int k)
        {
            if ((n >> (k - 1) & 1) == 1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        /// <summary>
        /// Naive solution
        /// Compare first bit to 1 if it's set increase result by one and right shift by one(remove first digit)
        /// </summary>
        /// <param name="n"></param>
        internal void CountSetBits_solution_1(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result += n & 1;
                n >>= 1;
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// By using brian kerningam algorithm
        /// when you n & (n-1) it will make all bit to set before first set and make this bit zero
        /// 101000(40) & 100111 (39) make first 3 bit one and fourth bit zero
        /// basically it will remove right most set bit from number
        /// </summary>
        /// <param name="n"></param>
        internal void CountSetBits_solution_2(int n)
        {
            int result = 0;
            while (n > 0)
            {
                n = n & (n - 1);

                result++;
            }
            Console.WriteLine(result);
        }

        internal void CountSetBits_solution_3(int n)
        {
            int[] table = new int[255];
            table[0] = 0;
            //one time table fill for all numbers
            for (int i = 1; i < 256; i++)
            {
                table[i] = (i & 1) + table[i / 2];
            }

            int result = table[n & 0xff];
            n = n >> 8;
            result += table[n & 0xff];
            n = n >> 8;
            result += table[n & 0xff];
            n = n >> 8;
            result += table[n & 0xff];

            Console.WriteLine(result);
        }

        /// <summary>
        /// if a number is power of 2 there will be only one set bit
        /// by doing n & (n-1) you will unset the only set bit and it become zero
        /// 1000(8) & 0111(7) = 0
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        internal bool CheckIfANumberIsPowerOfTwo(int n)
        {
            return n != 0 && (n & (n - 1)) == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        internal void findTwoOddNumbers(int[] a)
        {
            int result1 = 0, result2 = 0, xor = 0;
            for (int i = 0; i < a.Length; i++)
            {
                xor ^= a[i];
            }

            ///find right most set bit in xor and divide array into two part
            /// n $ ~(n-1) gives last set bit 10010 & ~(10001) = 10010 & 01110 = 00010 (only right most set bit)
            int rightMostSetBit = xor & ~(xor - 1);

            // create result based on right most set each will contain one odd number
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] & rightMostSetBit) == 0)
                {
                    result1 ^= a[i];
                }
                else
                {
                    result2 ^= a[i];
                }
            }
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        /// <summary>
        /// time complexity = theta(2^n*n)
        /// </summary>
        /// <param name="s"></param>
        internal void PowerSetsOfString(string s)
        {
            // calculate total power sets
            int totalSet = (int)Math.Pow(2, s.Length);

            // outer loop will run to total number of power sets
            for (int counter = 0; counter < totalSet; counter++)
            {
                //Inner loop will run to string length
                for (int j = 0; j < s.Length; j++)
                {
                    //checking which character we have to print at this counter
                    if ((counter & (1 << j)) != 0)
                    {
                        Console.Write(s[j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public int getFirstSetBit(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            int pos = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    pos++;
                    return pos;
                }
                pos++;
                n = n >> 1;
            }
            return pos;

        }

        public int posOfRightMostDiffBit(int m, int n)
        {
            if (m == n)
            {
                return -1;
            }
            int xor = m ^ n;
            return getFirstSetBit(xor);
        }

        public bool checkKthBit(int n, int k)
        {
            n = n >> k - 1;
            return (n & 1) == 1;
        }

        public int countSetBits(int N)
        {
            int setBits = 0;
            for (int i = 1; i <= N; i++)
            {
                if ((i & (i - 1)) == 0)
                {
                    setBits++;
                }
                else
                {
                    int j = i;
                    while (j > 0)
                    {
                        if ((j & 1) == 1)
                        {
                            setBits++;
                        }
                        j = j >> 1;
                    }
                }
            }
            return setBits;
        }

        public int countBitsFlip(int a, int b)
        {
            int count = 0;
            while (b > 0)
            {
                int aBit = a & 1;
                int bBit = b & 1;
                if (aBit != bBit)
                    count++;
                a = a >> 1;
                b = b >> 1;
            }

            return count;
        }

        public bool isSparse(int n)
        {
            int consuctiveBit = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    consuctiveBit++;
                    if (consuctiveBit > 1)
                    {
                        return false;
                    }
                }
                else
                {
                    consuctiveBit = 0;
                }
                n >>= 1;
            }
            return true;
        }

        public int maxConsecutiveOnes(int n)
        {
            int currentConsucetive = 0, longestConsucetive = 0;

            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    currentConsucetive++;
                    longestConsucetive = Math.Max(currentConsucetive, longestConsucetive);
                }
                else
                {
                    longestConsucetive = Math.Max(currentConsucetive, longestConsucetive);
                    currentConsucetive = 0;
                }
                n >>= 1;
            }
            return longestConsucetive;
        }

        /// <summary>
        /// O(1) time complexity
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int swapBits(int n)
        {
            /// 0XAAAAAAAA is number with all even bit set in 32-bit number
            long evenBit = n & 0XAAAAAAAA;

            ///0X55555555 is number with all odd bit set in 32-bit number
            long oddBit = n & 0X55555555;

            /// right shift even bit by one and left shift odd bit by one
            evenBit = evenBit >> 1;
            oddBit = oddBit << 1;
            ///combine them with using or
            return (int)(evenBit | oddBit);
        }

        /// <summary>
        /// O(constant) complexity as runnig loop only 16 time for any number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int swapBits_2(int n)
        {
            for (int i = 0; i < 32; i += 2)
            {
                // get ith bit (1st, 3rd, 5th..)
                int ithBit = (n >> i) & 1;

                // get (i+1)th bit (2nd, 4th, 6th..)
                int i_1Bit = (n >> (i + 1)) & 1;

                // remove ith bit from i position and insert it at i+1 position
                n = n - (ithBit << i) - (i_1Bit << (i + 1)) + (ithBit << (i + 1)) + (i_1Bit << i);
            }
            return n;
        }

        public int maxAND(int[] arr, int n)
        {
            int maxAND = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int andValue = arr[i] & arr[j];
                    if (andValue > maxAND)
                    {
                        maxAND = andValue;
                    }
                }
            }

            return maxAND;

        }

        public int maxANDOptimized(int[] arr, int n)
        {
            int result = 0, count;

            /// run a loop for all 31 bit and check for all number which one is MSB bit for number
            for (int i = 31; i >= 0; i--)
            {
                /// left shift 1 by i time and do or with result 
                /// in first occurence result =0 (0|pow(2,31) = pow(2,31) now check if 31st bit is set for any two number in array
                /// in second case result = pow(2,31) (pow(2,31) | pow(2,30)) now check if there are any two number 31st and 30th bit is set 
                count = countMSB((result | 1 << i), arr, n);

                /// if there are two number in array whose ith bit set do or wit hresult for it
                if (count >= 2)
                {
                    result |= 1 << i;
                }
            }
            return result;
        }

        private int countMSB(int pattern, int[] arr, int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if ((arr[i] & pattern) == pattern)
                {
                    count++;
                }
            }
            return count;
        }

        public int solution(int A, int B)
        {
            int result = A * B;
            int count = 0;

            while (result > 0)
            {
                count += result & 1;
                result >>= 1;
            }

            return count;

        }

        public int GetSumByIncreasingDigitByOne(int N)
        {
            int[] digits = N.ToString().Select(c => c - '0').ToArray();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return GetNumberFromDigits(digits);
                }
            }

            /// if all digits 9 return number
            return N + (int)Math.Pow(10, digits.Length);
        }

        public int getNumber(int n)
        {
            int sum = GetDigitSum(n);
            int current_number = n;
            for (int i = 0; i < sum; i++)
            {
                current_number = GetSumByIncreasingDigitByOne(current_number);

                int current_sum = GetDigitSum(current_number);

                if (current_sum == sum * 2)
                {
                    return current_number;
                }
            }

            return 0;
        }

        public int GetDigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public int GetNumberFromDigits(int[] digits)
        {
            int result = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                result = result * 10 + digits[i];
            }
            return result;
        }

    }
}

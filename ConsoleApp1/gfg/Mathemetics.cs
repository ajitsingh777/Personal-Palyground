using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.gfg
{
    internal class Mathemetics
    {
        internal void TrailingZeroInFact(int n)
        {
            int zeroes = 0;
            for (int i = 5; i <= n; i *= 5)
            {
                zeroes += n / i;
            }
            Console.WriteLine(zeroes);
        }

        internal int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
        internal void LCM(int a, int b)
        {
            Console.WriteLine((a * b) / GCD(a, b));
        }
        internal bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }
            return true;
        }
        internal void PrimeFactor(int n)
        {
            if (n == 1) return;
            while (n % 2 == 0)
            {
                Console.Write(2);
                n /= 2;
            }
            while (n % 3 == 0)
            {
                Console.Write(3);
                n /= 3;
            }
            for (int i = 5; i * i <= n; i += 6)
            {
                while (n % i == 0)
                {
                    Console.Write(i);
                    n /= i;
                }
                while (n % (i + 2) == 0)
                {
                    Console.Write(i + 2);
                    n /= (i + 2);
                }
            }
            if (n > 3)
                Console.Write(n);
        }

        internal void AllDivisorOfNumber(int n)
        {
            int i = 1;
            for (; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            for (; i >= 1; i--)
            {
                if (n % i == 0 && n / i != i)
                {
                    Console.Write(n / i + " ");
                }
            }
        }

        internal void AllPrimeSmallerThanNumber(int n)
        {
            int[] isPrime = new int[n + 1];
            System.Array.Fill(isPrime, 1);
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i] == 1)
                {
                    for (int j = i * 2; j < isPrime.Length; j += i)
                    {
                        isPrime[j] = 0;
                    }
                }
            }
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Utility
    {
        public static void Method1()
        {
            Thread.Sleep(5000);
            Console.WriteLine("This is method one");
        }
        public static void Method2()
        {
            Console.WriteLine("this is method 2");
        }

        internal static void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}

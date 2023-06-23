using DSPractice.gfg.LinkedList.Videos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.HeapImplementation
{
    internal class Heap
    {
        int[] arr;
        int size, capacity;
        public Heap(int c)
        {
            arr = new int[c];
            capacity = c;
            size = 0;
        }

        public int left(int i) => 2 * i + 1;
        public int right(int i) => 2 * i + 2;
        public int parent(int i) => (i - 1) / 2;

        public void insert(int number)
        {
            if (size == capacity)
            {
                return;
            }
            arr[size++] = number;
            for (int i = size - 1; i > 0 && arr[parent(i)] > arr[i];)
            {
                (arr[parent(i)], arr[i]) = (arr[i], arr[parent(i)]);
                i = parent(i);
            }
        }


    }
}

using System;

namespace Heapsorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 42, 3, 4, 90 };


            QuickSort(A, 0, 3);
        }

        private static void QuickSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSort(A, p, q - 1);
                QuickSort(A, q + 1, r);
            }
        }

        private static int Partition(int[] A, int p, int r)
        {
            int x = A[r];
            int i = p - 1;

        }
    }
}

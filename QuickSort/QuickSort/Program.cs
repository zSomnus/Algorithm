using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 13, 19, 9, 5, 12, 8, 7, 4, 21, 2, 6, 11 };
            //int[] A = { 2, 8, 7, 1, 3, 5, 6, 4 };
            Quicksorting(A, 0, A.Length - 1);

            if (A != null)
            {
                Console.WriteLine(String.Join(", ", A));
            }
        }

        private static void Quicksorting(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(a, p, r);
                Quicksorting(a, p, q - 1);
                Quicksorting(a, q + 1, r);
            }
        }

        private static int Partition(int[] a, int p, int r)
        {
            int x = a[r];    //A[r] pivol is the last element of the array
            int i = p - 1;

            for (int j = p; j <= r - 1; j++)
            {
                if (a[j] <= x)
                {
                    i = i + 1;
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }

            int temp1 = a[i + 1];
            a[i + 1] = a[r];
            a[r] = temp1;

            return i + 1;
        }
    }
}

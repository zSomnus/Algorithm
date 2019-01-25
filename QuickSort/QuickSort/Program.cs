﻿using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = { 9, 3, 6, 8, 1, 4 };
            //Partition(A, 0, 5);
            Quicksorting(A, 0, 5);

            if (A != null)
            {
                Console.WriteLine(String.Join(", ", A));
            }
        }

        private static void Quicksorting(int[] a, int p, int r)
        {
            int q = Partition(a, p, r);
            if (p<r)
            {
                //Console.WriteLine(Convert.ToInt32(Partition(a, p, r)));

                Console.WriteLine(q);
                Quicksorting(a, p, q - 1);
                Quicksorting(a, q + 1, r);
            }

        }

        private static int Partition(int[] a, int p, int r)
        {
            int x = a[r];
            int i = p;
            for (int j = p; j < r; j++)
            {
                if (a[j] <= x)
                {
                    i++;
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }
                //Console.WriteLine(i);
                int temp1 = a[i];
                a[i] = a[r];
                a[r] = temp1;
            }
            return i + 1;
        }
    }
}
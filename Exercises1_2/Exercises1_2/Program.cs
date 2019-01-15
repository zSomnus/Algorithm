using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //find largest n such that
            //n < 8 * log2(n)
            for (int n = 1000; n > 0; n--)
            {
                if (n < 8 * Math.Log(n, 2))
                {
                    Console.WriteLine($"answer is {n}");
                    Console.ReadLine();
                    
                }
            }
            //if n < 43 ensertion sort is faster than
            */

            /*
            //find smallest number where n > 0
            for (int n = 1; n < 1000; n++)
            {
                if(100 * Math.Pow(n, 2)<Math.Pow(2, n))
                {
                    Console.WriteLine($"The answer is {n}");
                    //Console.ReadLine();
                    break;
                }
            }
            */




            //Insertion sort
            int[] array = new int[] { 31, 41, 59, 26, 41, 58 };
            //InsertionSort(array);
            PrintInsertionSort(array);
            PrintInsertionSortD(array);
            AddBinary();
            Console.ReadKey();
        }

        private static void AddBinary()
        {
            int n = 4;
            bool[] array1 = new bool[n];
            bool[] array2 = new bool[n];
        }

        private static void PrintInsertionSortD(int[] array)
        {
            InsertionSortD(array);

            Console.WriteLine("The result of Insertion Sort (Descending order) is: ");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintInsertionSort(int[] array)
        {
            InsertionSort(array);

            Console.WriteLine("The result of Insertion Sort (Ascending order) is: ");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void InsertionSortD(int[] array)
        {
            int key;
            int i;
            for (int j = 1; j < array.Length; j++)
            {
                key = array[j];
                i = j - 1;
                while (i > -1 && array[i] < key)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }
                array[i + 1] = key;
            }
        }

        private static void InsertionSort(int[] array)
        {
            int key;
            int i;
            for (int j = 1; j < array.Length; j++)
            {
                key = array[j];
                i = j - 1;
                while(i > -1 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }
                array[i + 1] = key;
            }
        }
    }
}

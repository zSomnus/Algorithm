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
            int[] array = new int[] { 31, 41, 59, 26, 41, 58 };
            LargestN();
            SmallestN();
            PrintInsertionSort(array);
            PrintInsertionSortD(array);
            AddBinary();
            Console.ReadKey();
        }

        private static void SmallestN()
        {
            //find smallest number where n > 0
            for (int n = 1; n < 1000; n++)
            {
                if (100 * Math.Pow(n, 2) < Math.Pow(2, n))
                {
                    Console.WriteLine($"The smallest numger is {n}");
                    break;
                    //Console.ReadLine();
                }
            }
        }

        private static void LargestN()
        {
            //find largest n such that
            //n < 8 * log2(n)
            for (int n = 1000; n > 0; n--)
            {
                if (n < 8 * Math.Log(n, 2))
                {
                    Console.WriteLine($"The largest number is {n}");
                    break;
                }
            }
            //if n < 43 ensertion sort is faster than
        }

        private static void AddBinary()
        {
            Console.WriteLine();
            Console.WriteLine();

            //int n = 4;

            Console.WriteLine("First binary number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //string num1 = Console.ReadLine();
            string binaryNum1 = Convert.ToString(num1, 2);

            Console.WriteLine("Second binary number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //string num2 = Console.ReadLine();
            string binaryNum2 = Convert.ToString(num2, 2);


            Console.WriteLine($"Your number are {binaryNum1} ({binaryNum1.Length}) and {binaryNum2} ({binaryNum2.Length})");

            bool[] array1 = new bool[binaryNum1.Length];

            for (int i = 0; i < binaryNum1.Length; i++)
            {
                Console.WriteLine(binaryNum1.Substring(i, 1));
                if (binaryNum1.Substring(i, 1) == "1")
                {
                    array1[i] = true;
                }
                else
                {
                    array1[i] = false;
                }
            }
            foreach (var item in array1)
            {
                Console.WriteLine(item.ToString());
            }

            bool[] array2 = new bool[binaryNum2.Length];
            for (int i = 0; i < binaryNum2.Length; i++)
            {
                Console.WriteLine(binaryNum2.Substring(i, 1));
                if (binaryNum2.Substring(i, 1) == "1")
                {
                    array2[i] = true;
                }
                else
                {
                    array2[i] = false;
                }
            }
            foreach (var item in array2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("The final result is: ");
            string total = Convert.ToString(num1 + num2, 2);
            bool[] final = new bool[total.Length];
            for (int i = 0; i < total.Length; i++)
            {
                Console.WriteLine(total.Substring(i, 1));
                if (total.Substring(i, 1) == "1")
                {
                    final[i] = true;
                }
                else
                {
                    final[i] = false;
                }
            }
            foreach (var item in final)
            {
                Console.WriteLine(item.ToString());
            }
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

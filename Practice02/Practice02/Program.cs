/*
 * felixsoum 
 * 
 * 420-J13-AS
 * 
 * Practice recursion, merge sort, heap and heapsort.
 */

using System;

namespace Practice02
{
    public class Program
    {
        static int[] A;

        static void Main(string[] args)
        {
            //A.
            int fiboInput = 10;
            Console.WriteLine($"Fibonnaci {fiboInput}-th term is {Fibonacci(fiboInput)}");

            //B.
            A = new int[] { 1, 6, 7, 10, 12, 14, 22, 26 };
            int searchValue = 12;
            int resultIndex = BinarySearch(A, searchValue, 0, A.Length - 1);
            Console.WriteLine($"Value {searchValue} is at index {resultIndex}");

            //C.
            A = new int[] { 2, 4, 8, 9, 11, 25, 34, 57, 3, 5, 7, 15, 26, 33, 44 };
            Merge(A, 0, 7, 14);

            //D.
            A = new int[] { 64, 14, 47, 32, 75, 34, 75, 34, 56, 25, 45, 34, 67, 45, 67 };
            MergeSort(A);

            //E.
            A = new int[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            MaxHeapify(A, 3);

            //F.
            A = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 0 };
            //BuildMaxHeap(A);
            HeapSort(A);

            //G.
            A = new int[] { 64, 14, 47, 32, 75, 34, 75, 34, 56, 25, 45, 34, 67, 45, 67 };
            HeapSort(A);

            if (A != null)
            {
                Console.WriteLine(String.Join(", ", A));
            }
        }

        /// <summary>
        /// Computes the n-th Fibonnaci number.
        /// </summary>
        /// <param name="n">Sequence number.</param>
        /// <returns>The value of the n-th Fibonacci number.</returns>
        public static int Fibonacci(int n)
        {
            //TODO
            return -1;
        }

        /// <summary>
        /// Finds the index of given value in a sorted array.
        /// </summary>
        /// <param name="A">Sorted input array.</param>
        /// <param name="value">Value to search for.</param>
        /// <param name="start">Start index of search.</param>
        /// <param name="end">End index of search</param>
        /// <returns>The index containing the value in the array.</returns>
        public static int BinarySearch(int[] A, int value, int start, int end)
        {
            //TODO
            return -1;
        }

        /// <summary>
        /// The procedure that merges two sorted subarrays into one.
        /// </summary>
        /// <param name="A">Array containing the subarrays.</param>
        /// <param name="p">Starting index of first subarray.</param>
        /// <param name="q">End index of first subarray.</param>
        /// <param name="r">End index of second subarray.</param>
        public static void Merge(int[] A, int p, int q, int r)
        {
            //TODO
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (int n = 0; n < n1; n++)
            {
                L[n] = A[p + n];
            }

            for (int n = 0; n < n2; n++)
            {
                R[n] = A[q + 1 + n];
            }

            L[L.Length - 1] = int.MaxValue;
            R[R.Length - 1] = int.MaxValue;

            int i = 0;
            int j = 0;

            for (int k = p; k <= r; k++)
            {
                if (L[i] < R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }
        }

        /// <summary>
        /// Sorts a subarray using merge sort.
        /// </summary>
        /// <param name="A">Subarray to sort</param>
        /// <param name="p">Start index of subarray</param>
        /// <param name="r">End index of subarray</param>
        public static void MergeSort(int[] A, int p, int r)
        {
            //TODO
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }

        /// <summary>
        /// Sorts an array using merge sort.
        /// </summary>
        /// <param name="A">Array to sort</param>
        public static void MergeSort(int[] A)
        {
            MergeSort(A, 0, A.Length - 1);
        }

        /// <summary>
        /// Finds the index of the left child in a heap.
        /// </summary>
        /// <param name="i">Index of parent node.</param>
        /// <returns>The index of the left child.</returns>
        public static int Left(int i)
        {
            return i * 2 + 1;
        }

        /// <summary>
        /// Finds the index of the right child in a heap.
        /// </summary>
        /// <param name="i">Index of parent node.</param>
        /// <returns>The index of the right child.</returns>
        public static int Right(int i)
        {
            return i * 2 + 2;
        }

        /// <summary>
        /// Maintain the max-heap property at a subtree.
        /// </summary>
        /// <param name="A">Array implementing the heap.</param>
        /// <param name="i">Index of subtree.</param>
        /// <param name="heapSize">Number of elements in heap.</param>
        public static void MaxHeapify(int[] A, int i, int heapSize)
        {
            //TODO
            int L = Left(i);
            int R = Right(i);
            int largest = 0;

            if (L < heapSize && A[L] > A[i])
            {
                largest = L;
            }
            else
            {
                largest = i;
            }

            if (R < heapSize && A[R] > A[largest])
            {
                largest = R;
            }

            if (largest != i)
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;

                MaxHeapify(A, largest);
            }
        }

        /// <summary>
        /// Maintain the max-heap property at a subtree.
        /// </summary>
        /// <param name="A">Array implementing the heap.</param>
        /// <param name="index">Index of subtree.</param>
        public static void MaxHeapify(int[] A, int index)
        {
            MaxHeapify(A, index, A.Length);
        }

        /// <summary>
        /// Converts an entire array into a heap.
        /// </summary>
        /// <param name="A">Array to convert into heap.</param>
        public static void BuildMaxHeap(int[] A)
        {
            //TODO
            int heapSize = A.Length;
            for (int i = heapSize - 1; i >= 0; i--)
            {
                MaxHeapify(A, i);
            }
        }

        /// <summary>
        /// Sorts an array using heapsort.
        /// </summary>
        /// <param name="A">Array to sort.</param>
        public static void HeapSort(int[] A)
        {
            BuildMaxHeap(A);
            int heapSize = A.Length - 1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                int temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                //Array.Resize(ref A, heapSize - 1);
                heapSize--;
                MaxHeapify(A, 0);
            }
        }
    }
}

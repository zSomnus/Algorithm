using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(4);
            lst.Add(7);
            lst.Add(2);
            lst.Add(0);
            lst.Add(8);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> finalLst = sort(lst);
            foreach (var item in finalLst)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static List<int> sort(List<int> lst)
        {
            if (lst.Count <= 1)
            {
                return lst;
            }
            int mid = lst.Count / 2;
            List<int> left = new List<int>();  // 定义左侧List
            List<int> right = new List<int>(); // 定义右侧List
                                               // 以下兩個循環把 lst 分為左右兩個 List
            for (int i = 0; i < mid; i++)
                left.Add(lst[i]);
            for (int j = mid; j < lst.Count; j++)
                right.Add(lst[j]);
            left = sort(left);
            right = sort(right);
            return merge(left, right);
        }

        static List<int> merge(List<int> left, List<int> right)
        {
            List<int> temp = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    temp.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    temp.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            if (left.Count > 0)
            {
                for (int i = 0; i < left.Count; i++)
                    temp.Add(left[i]);
            }
            if (right.Count > 0)
            {
                for (int i = 0; i < right.Count; i++)
                    temp.Add(right[i]);
            }
            return temp;
        }
    }
}

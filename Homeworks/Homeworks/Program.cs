using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Permutation ---------------------------------");
            Console.WriteLine(PalindromePermutation("hello"));
            Console.WriteLine(PalindromePermutation("abcabca"));
            Console.WriteLine(PalindromePermutation("cbaacb"));

            Console.WriteLine("Palindrome Permutation ---------------------------------");

        }
        static bool PalindromePermutation(string str)
        {
            int a = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c] += 1;
                }
            }

            foreach(KeyValuePair<char, int> kv in dict)
            {
                if(kv.Value % 2 != 0)
                {
                    a++;
                }
            }

            if(a > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication121
{
    class Program
    {
        static void Main(string[] args)
        {
            //anagram
            string s1 = "abcdx", s2 = "dcaby";
            bool isAnagram = false;

            //isAnagram = CheckAnagram11(s1, s2);

            isAnagram = CheckAnagram22(s1, s2);

            Console.Write("o/p :" + isAnagram);

            //string a = String.Concat(s1.OrderBy(c => c));
            //string b = String.Concat(s2.OrderBy(c => c));

            //if (a == b)
            //    Console.Write("o/p : TRUE");
            //else
            //    Console.Write("o/p : FALSE");

            Console.ReadKey();
        }

        private static bool CheckAnagram22(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            if (s1 == s2)
                return true;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (dict.ContainsKey(s1[i]))
                    dict[s1[i]] = dict[s1[i]] + 1;
                else
                    dict.Add(s1[i], 1);

                if (dict.ContainsKey(s2[i]))
                    dict[s2[i]] = dict[s2[i]] - 1;
                else
                    dict.Add(s2[i], -1);
            }

            foreach (var d in dict)
            {
                if (d.Value != 0)
                    return false;
            }

            return true;
        }

        private static bool CheckAnagram11(string s1, string s2)
        {
            // Time Complexity: O(n)

            if (s1.Length != s2.Length)
                return false;

            if (s1 == s2)
                return true;

            const int CHARS = 256;
            int[] arr = new int[CHARS];
            for (int i = 0; i < s1.Length; i++)
            {
                arr[s1[i] - 'a']++;
                arr[s2[i] - 'a']--;
            }

            for (int i = 0; i < CHARS; i++)
            {
                if (arr[i] != 0)
                    return false;
            }

            return true;
        }
    }
}

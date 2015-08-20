using System;
using System.Linq;

namespace Longest_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] someArrayOfString = { "a", "aa", "aaa", "aaaa", "aaaaa" };

            string longest = someArrayOfString
                .OrderBy(s => -s.Length)
                .First();

            Console.WriteLine(longest);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static readonly char[] separators = { '.', ',', '!', '?', ':', '-', ' ' };

    static void Main(string[] args)
    {
        string[] a = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Array.Sort(a);
        foreach (string s in a)
        {
            Console.WriteLine(s);
        }

    }
}
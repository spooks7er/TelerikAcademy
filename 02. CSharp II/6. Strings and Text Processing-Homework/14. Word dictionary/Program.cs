using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 14. Word dictionary
//• A dictionary is stored as a sequence of text lines containing words and their explanations.
//• Write a program that enters a word and translates it by using the dictionary.

//.NET      platform for applications from Microsoft 
//CLR       managed execution environment for .NET 
//namespace hierarchical organization of classes 

class Program
{
    static readonly Dictionary<string, string> dictionary = new Dictionary<string, string>()
    {
        {".NET", "Platform for applications from Microsoft"},
        {"CLR", "Managed execution environment for .NET"},
        {"namespace", "Hierarchical organization of classes"}
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Search for: ");
            string input = Console.ReadLine();

            if (dictionary.ContainsKey(input))
            {
                System.Console.Write("Explanation: ");

                Console.WriteLine(dictionary[input]);
            }
        }
    }
}
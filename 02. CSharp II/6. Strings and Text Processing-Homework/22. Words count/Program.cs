using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 22. Words count
//• Write a program that reads a string from the console and lists all 
//different words in the string along with information how many times each word is found.
class Program
{
    static readonly char[] separators = { '.', ',', '!', '?', ':', '-', ' ' };

    static void Main(string[] args)
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day.";
        text = text.ToLower();

        string[] textArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> words = new Dictionary<string, int>();

        for (int i = 0; i < textArr.Length; i++)
        {
            if (!words.ContainsKey(textArr[i]))
            {
                words.Add(textArr[i].Trim(), 1);
            }
            else if (words.ContainsKey(textArr[i]))
            {
                words[textArr[i]]++;
            }
        }
        foreach (var item in words)
        {
            if (item.Value != 0)
            {
                Console.WriteLine("{0,-10} --> {1,2} times", item.Key, item.Value);
            }
        }
    }
}
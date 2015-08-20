using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 20. Palindromes
//• Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe.
class Program
{
    static readonly char[] separators = { '.', ',', '!', '?', ':', '-', ' ' };

    static void Main(string[] args)
    {
        string text = "ABBA  , hasdas ,lamal  ,a231dwsw , jojoj  , exe asdasdasd, bob,a sd asd ,  shish, alkukla";

        string[] textArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < textArr.Length; i++)
        {
            char[] chArr = textArr[i].ToCharArray();
            Array.Reverse(chArr);
            string word = new string(chArr);
            if (word==textArr[i])
            {
                Console.WriteLine(word);
            }
        }
    }
}
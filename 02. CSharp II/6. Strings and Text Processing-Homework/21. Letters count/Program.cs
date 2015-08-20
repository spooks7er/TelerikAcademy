using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day.";
        text = text.ToLower();
        
        // with a dictionary that cheks the sentance with one pass and counts 
        //how many time it encounters a letter, and it's faster
        
        Dictionary<char, int> letters = new Dictionary<char, int>()
        {
            {'a', 0},{'b', 0},{'c', 0},{'d', 0},{'e', 0},
            {'f', 0},{'g', 0},{'h', 0},{'i', 0},{'j', 0},
            {'k', 0},{'l', 0},{'m', 0},{'n', 0},{'o', 0},
            {'p', 0},{'q', 0},{'r', 0},{'s', 0},{'t', 0},
            {'u', 0},{'v', 0},{'w', 0},{'x', 0},{'y', 0},
            {'z', 0}
        };

        for (int i = 0; i < text.Length; i++)
        {
            if (letters.ContainsKey(text[i]))
            {
                letters[text[i]]++;
            }
        }

        foreach (var item in letters)
        {
            if (item.Value != 0)
            {
                Console.WriteLine("{0} --> {1,2} times", item.Key, item.Value);
            }
        }




        // With a nested for loop that cheks letter by letter for every letter in the alphabet
        
        //for (int i = 97; i <= 122; i++)
        //{
        //    int letterCounter = 0;
        //    char currentLetter = (char)i;
        //    for (int j = 0; j < text.Length; j++)
        //    {
        //        if (currentLetter == text[j])
        //        {
        //            letterCounter++;
        //        }
        //    }
        //    if (letterCounter != 0)
        //    {
        //        Console.WriteLine("{0} --> {1} times", currentLetter, letterCounter);
        //        letterCounter = 0;
        //    }
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static char[] punctuation = { ',', '.', '(', ')', ';', '-', '!', '?', ' ' };
    static void Main(string[] args)
    {
        string searchWord = Console.ReadLine();

        int linesNumber = int.Parse(Console.ReadLine());

        var Lines = new Dictionary<int, string>();

        for (int i = 0; i < linesNumber; i++)
        {
            var currentLine = Console.ReadLine().Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

            int relevIndex = 0;
            for (int j = 0; j < currentLine.Length; j++)
            {
                string word = currentLine[j];
                if (word.ToLower()==searchWord.ToLower())
                {
                    currentLine[j] = currentLine[j].ToUpper();
                    relevIndex++;
                }
            }
            Lines.Add(relevIndex, string.Join(" ", currentLine));
        }

        var list = Lines.Keys.ToList().OrderByDescending(i => i);

        foreach (var key in list)
        {
            Console.WriteLine(Lines[key]);
        }
    }
}
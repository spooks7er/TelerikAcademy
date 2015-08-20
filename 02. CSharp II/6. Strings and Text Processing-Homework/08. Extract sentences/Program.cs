using System;
using System.Linq;
using System.Text;
//Problem 8. Extract sentences
//• Write a program that extracts from a given text all sentences containing given word.

//Example:

//The word is: in

//The text is: 

//We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is:
//We are living in a yellow submarine. 
//We will move out of it in 5 days.

//Consider that the sentences are separated by  .  and the words – by non-letter symbols.
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter your text:");
        //string text = Console.ReadLine();
        //Console.WriteLine("Enter a word to search:");
        //string word = Console.ReadLine();

        string text = @"We are living in a yellow submarine. We don't have anything else. 
        Inside the submarine is very tight. 
        So we are drinking all the day. 
        We will move out of it in 5 days.";
        string word = "in";

        string word1 = " " + word;
        string word2 = word + " ";


        //var textArr = text.ToCharArray();

        int startIndex = 0;
        while (true)
        {
            int dotIndex = text.IndexOf('.', startIndex);
            if (dotIndex < 0)
            {
                break;
            }
            string sentance = text.Substring(startIndex, dotIndex - startIndex + 1).Trim();
            if (sentance.Contains(word1)||sentance.Contains(word2))
            {
                Console.Write(sentance+" ");
            }
            startIndex = dotIndex + 1;
        } Console.WriteLine();
    }
}
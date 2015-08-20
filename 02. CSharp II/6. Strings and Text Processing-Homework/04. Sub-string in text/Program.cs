using System;
//Problem 4. Sub-string in text
//• Write a program that finds how many times a sub-string is contained in a given text 
//(perform case insensitive search).

//Example:
//The target sub-string is  in 
//The text is as follows: We are living in an yellow submarine. We don't have anything else. 
//inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is:  9 
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a word to search for text: ");
        string search = Console.ReadLine();


/*       string text = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
*/        //string search = "in";
        
        int count = 0;
        int index = 0;
        while (true)
        {
            int found = text.ToLower().IndexOf(search.ToLower(), index);
            if (found < 0)
            {
                break;
            }
            count++;
            index = found + 1;
        }
        Console.WriteLine(count);
    }
}
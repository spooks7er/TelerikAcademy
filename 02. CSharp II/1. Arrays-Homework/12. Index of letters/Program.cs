using System;
//Write a program that creates an array containing all letters from the alphabet ( A-Z ).
//• Read a word from the console and print the index of each of its letters in the array.

class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0 + 'A'; i < alphabet.Length + 'A'; i++)
        {
            alphabet[i - 'A'] = (char)i;
            Console.WriteLine("{0} - {1}", i - 'A', alphabet[i - 'A']);
        }
        Console.WriteLine("Enter a WORD using Capital Case");
        string word = Console.ReadLine();

        Console.WriteLine("The indexes of the letter of the word are");
        for (int i = 0; i < word.Length; i++)
        {
            int letter = word[i] - 'A';
            int index = BinarySearch(alphabet, letter, 0, alphabet.Length - 1);
            
            if (i != word.Length-1)
            {
                Console.Write(index+1 + ", ");
            }
            else
            {
                Console.WriteLine(index+1);
            }
        }

        //for (int i = 0; i < word.Length; i++)
        //{
        //    if (i != word.ToCharArray().Length - 1)
        //    {
        //        Console.Write(((int)word[i] - 'a') + ", ");

        //    }
        //    else
        //    {
        //        Console.WriteLine((int)word[i] - 'a');
        //    }
        //}
    }

    static int BinarySearch(char[] array, int value, int left, int right)
    {
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] - 'A' == value)
            {
                return middle;
            }
            else if (array[middle] - 'A' > value)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}
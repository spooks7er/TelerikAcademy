using System;
//• Write a program that compares two  char  arrays lexicographically (letter by letter).
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter arrays length");
        int len = int.Parse(Console.ReadLine());
        char[] array1 = new char[len];
        char[] array2 = new char[len];

        Console.WriteLine("Enter the elements of array 1, each on a new line.");
        for (int i = 0; i < len; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of array 2, each on a new line.");
        for (int i = 0; i < len; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < len; i++)
        {
            int compare = array1[i] - array2[i];
            if (compare < 0)
            {
                Console.WriteLine("{0} is lexicographically before {1}", array1[i], array2[i]);
            }
            else if (compare > 0)
            {
                Console.WriteLine("{0} is lexicographically after {1}", array1[i], array2[i]);
            }
            else if (compare == 0)
            {
                Console.WriteLine("{0} and {1} are lexicographically equivalent", array1[i], array2[i]);
            }
        }
    }
}
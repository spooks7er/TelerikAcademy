using System;
//• Write a program that reads two  integer  arrays from the console and compares them element by element.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter arrays length");
        int len = int.Parse(Console.ReadLine());
        int[] array1 = new int[len];
        int[] array2 = new int[len];
        
        Console.WriteLine("Enter the elements of array 1, each on a new line.");
        for (int i = 0; i < len; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of array 2, each on a new line.");
        for (int i = 0; i < len; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < len; i++)
        {
            if (array1[i]==array2[i])
            {
                Console.WriteLine("{0} is equal to {1}", array1[i] , array2[i]);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", array1[i], array2[i]);
            }
        }
    }
}
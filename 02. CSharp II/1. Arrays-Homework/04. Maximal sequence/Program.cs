using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that finds the maximal sequence of equal elements in an array.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array length");
        int len = int.Parse(Console.ReadLine());

        int[] array = new int[len];

        Console.WriteLine("Enter the elements of the array, each on a new line.");
        for (int i = 0; i < len; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        if (len == 1)
        {
            Console.WriteLine("The maximal sequence of equal elements is {0}.", 1);
            Console.WriteLine("The sequence is {0}.", array[0]);
            return;
        }


        List<int> sequence = new List<int>();
        List<int> maxSequence = new List<int>();

        int count = 0;
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] == array[i + 1])
            {
                count++;
                sequence.Add(array[i]);
                if (count > max)
                {
                    max = count;
                    maxSequence = sequence.ToList();
                }
            }
            else if ((i > 0 && i < array.Length-1) && (array[i] == array[i - 1] || array[i] == array[i + 1]))
            {

                if (array[i] != array[i - 1])
                {
                    count = 0;
                    sequence.Clear();
                } 
                count++;
                sequence.Add(array[i]);
                if (count > max)
                {
                    max = count;
                    maxSequence = sequence.ToList();
                }
            }
            else if (i == array.Length-1 && array[i] == array[i - 1])
            {
                count++;
                sequence.Add(array[i]);
                if (count > max)
                {
                    max = count;
                    maxSequence = sequence.ToList();
                }
            }
            else
            {
                count = 0;
                sequence.Clear();
            }
        }

        Console.WriteLine("The maximal sequence of equal elements is {0}.", max);
        Console.WriteLine("The sequence is {0}.", string.Join(", ", maxSequence));
    }
}
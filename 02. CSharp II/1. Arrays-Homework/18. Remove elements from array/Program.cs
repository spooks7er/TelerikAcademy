using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that reads an array of integers and removes from 
//it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//• Print the remaining sorted array.

//6, 1, 4, 3, 0, 3, 6, 4, 5 
//   1,    3,    3,    4, 5 

class Program
{
    static void Main(string[] args)
    {                                     //   1,    3,    3,    4, 5 
        List<int> numbers = new List<int> { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

        Console.WriteLine(string.Join(", ", numbers));

        //first we remove all elements that greater than the current index and are before it
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] > numbers[i])
            {
                numbers.RemoveAt(i - 1);
            }
        }
        
        //then we remove all elements that lesser than the current index and are after it
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i + 1] < numbers[i])
            {
                numbers.RemoveAt(i + 1);
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that counts how many times given number appears in given array.
//• Write a test program to check if the method is workings correctly.

class Program
{
    public static Random rand = new Random();
    static void Main()
    {
        int testCount = 10;
        int testRepeat = 3;
        for (int i = 1; i <= testCount; i++)
        {
            int number = rand.Next(0, 21); // choose a random number to cout it's appearances
            int arrLen = rand.Next(10, 101);// choose random array length
            int[] array = Enumerable.Range(0, arrLen).Select(n => rand.Next(0, 21)).ToArray();// create array of random ints from 0 to 20
            //int numberCount = rand.Next(0, arrLen);

            int tValue = ApprearCount(array, number);
            Console.WriteLine("Test {0},   Value {1}", i, tValue);

            for (int j = 1; j <= testRepeat; j++)
            {
                int trValue = ApprearCount(array, number);
                Console.WriteLine("Repeat {0}, Value {1} - {2}", j, trValue, (trValue == tValue ? "Pass" : "Fail"));
            }
            Console.WriteLine();
        }
    }

    public static int ApprearCount(int[] array, int number)
    {
        int count = 0;
        foreach (int asd in array)
        {
            if (number == number)
            {
                count++;
            }
        }

        return count;
    }
}
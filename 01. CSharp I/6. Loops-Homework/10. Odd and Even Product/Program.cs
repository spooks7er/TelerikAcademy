using System;
//You are given  n  integers (given in a single line, separated by a space).
//• Write a program that checks whether the product of the odd elements is equal 
//to the product of the even elements.
//• Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] myString = input.Split(' ');

        int even = 1;
        int odd = 1;
        for (int i = 1; i <= myString.Length; i++)
        {
            int number = int.Parse(myString[i - 1]);
            if (i % 2 == 0)
            {
                even *= number;
            }
            else if (i % 2 != 0)
            {
                odd *= number;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("product = {0}", odd);
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("odd_product = {0}", odd);
            Console.WriteLine("even_product = {0}", even);
            Console.WriteLine("no");
        }
    }
}
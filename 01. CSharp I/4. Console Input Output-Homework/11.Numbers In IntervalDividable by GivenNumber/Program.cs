using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = 17;
        int b = 25;
        int c = 0;
        List<int> nums = new List<int>();
        for (int i = a; i <= b; i++)
        {
            if (i%5 ==0)
            {
                nums.Add(i);
                c++;
            }
        }
        Console.WriteLine(c);
        for (int i = 0; i < nums.Count; i++)
        {    
            Console.WriteLine(nums[i]);
        }
    }
}
﻿using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a whole number.");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
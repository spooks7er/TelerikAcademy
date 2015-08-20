using System;
//Problem 1. Square root
//• Write a program that reads an integer number and calculates and prints its square root. 
//◦ If the number is invalid or negative, print  Invalid number .
//◦ In all cases finally print  Good bye .
//• Use  try-catch-finally  block.
class Program
{
    static void Main(string[] args)
    {
        try
        {
            uint a = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally 
        {
            Console.WriteLine("Good bye!"); 
        }     
    }
}
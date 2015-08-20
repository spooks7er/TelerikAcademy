using System;
//Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b .
//• Use the Euclidean algorithm (find it in Internet).
class Program
{
    static void Main(string[] args)
    {
        int a = 60;
        int b = 40;

        int Remainder;

        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        Console.WriteLine(a); ;
    }
}
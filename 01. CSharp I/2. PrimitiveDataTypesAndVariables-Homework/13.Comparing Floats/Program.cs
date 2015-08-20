using System;

//Problem 13.* Comparing Floats
//• Write a program that safely compares floating-point 
//numbers (double) with precision  eps = 0.000001.
//Note: Two floating-point numbers  a  and  b  cannot be compared directly 
//by  a == b  because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely
//to each other than a fixed constant  eps.

class Program
{
    static void Main(string[] args)
    {
        double first = -0.00000007;
        double second = 0.00000007;
        double eps = 0.000001;
        if (Math.Abs(first - second) < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
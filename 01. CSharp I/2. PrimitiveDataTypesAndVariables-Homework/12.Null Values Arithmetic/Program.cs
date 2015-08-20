using System;

//Problem 12. Null Values Arithmetic• Create a program that assigns 
//null values to an integer and to a double variable. 
//• Try to print these variables at the console. 
//• Try to add some number or the null literal to these variables and print the result.

class Program
{
    static void Main(string[] args)
    {
        int? integer = null;
        double? doubler = null;
        Console.WriteLine("{0} ; {1}", (integer + 5), (doubler + null));

        integer = 5;
        Console.WriteLine(integer + 5);
    }
}
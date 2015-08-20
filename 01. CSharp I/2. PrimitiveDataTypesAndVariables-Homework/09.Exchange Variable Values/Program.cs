using System;

//Problem 9. Exchange Variable Values
//• Declare two integer variables  a  and  b  and assign them with
//5  and  10  and after that exchange their values by using some programming logic.
//• Print the variable values before and after the exchange.

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine(a + " and " + b + " before the exchange.");
        // Declaring a third variable witch stores one of the values during the exchange
        
        int valueholder = a;
        a = b;
        b = valueholder;
        
        // With using simple arithmetics
        
        //a = a * b;
        //b = a / b;
        //a = a / b;
        
        // With using the XOR operator
        
        //a ^= b;
        //b ^= a;
        //a ^= b;
        Console.WriteLine(a + " and " + b + " after the exchange.");
    }
}
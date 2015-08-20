using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
//Write a program that can solve these tasks: 
//◦ Reverses the digits of a number
//◦ Calculates the average of a sequence of integers
//◦ Solves a linear equation  a * x + b = 0  

//• Create appropriate methods.
//• Provide a simple text-based menu for the user to choose which task to solve.
//• Validate the input data: 
//◦ The decimal number should be non-negative
//◦ The sequence should not be empty
//◦ a  should not be equal to  0  
class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        while (true)
        {
            Console.WriteLine("1. Reverse the digits of a number.");
            Console.WriteLine("2. Calculate the average of a sequence of integers.");
            Console.WriteLine("3. Solve a linear equation  a * x + b = 0.");
            Console.WriteLine("Select a taks to run (1, 2 or 3):");
            string select = Console.ReadLine();
            Console.WriteLine();
            switch (select)
            {
                case "1": Console.WriteLine("1. Reverse the digits of a number."); 
                    Console.WriteLine();
                    Reversed(); break;
                case "2": Console.WriteLine("2. Calculate the average of a sequence of integers."); 
                    Console.WriteLine();
                    AvgOfSeq(); break;
                case "3": Console.WriteLine("3. Solve a linear equation  a * x + b = 0."); 
                    Console.WriteLine();
                    LinearEqSolver(); break;
                default: Console.WriteLine("Enter a valid number 1, 2 or 3."); 
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine();
        }
    }

    static void Reversed()
    {
        Console.WriteLine("Enter a number");
        string number = Console.ReadLine();
        if (number[0] == '-')
        {
            Console.WriteLine("The number must not be negative.");
            return;
        }
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        number = new string(charArray);
        decimal rev = decimal.Parse(number);
        Console.WriteLine("The reversed number is " + rev);
    }

    static void AvgOfSeq()
    {
        Console.WriteLine("Enter a sequence of integers separated by space");
        string seq = Console.ReadLine();
        string[] array = seq.Split(' ');

        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avg += int.Parse(array[i]);
        }
        avg /= array.Length;
        Console.WriteLine("The average of the sequence is " + avg);
    }

    static void LinearEqSolver()
    {
        Console.WriteLine("Enter your Linear Equasion like this : a * x + b = 0");

        //string eq = "5 * x - 3 = 0";
        //Console.WriteLine(eq);

        string eq = Console.ReadLine();
        string[] numbers = Regex.Split(eq, @"\D+");

        int a = 0;
        int b = 0;
        double x = 0;
        var ab = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (!string.IsNullOrEmpty(numbers[i]))
            {
                int n = int.Parse(numbers[i]);
                ab.Add(n);
            }
        }
        if (ab[0] == 0)
        {
            Console.WriteLine("The value of \"a\" must not be 0.");
            return;
        }
        int minusCount = 0;
        for (int i = 0; i < eq.Length; i++)
        {
            if (eq[i] == '-')
            {
                minusCount++;
            }
        }
        if (eq[0] == '-' && minusCount == 2)
        {
            ab[0] = -ab[0];
            ab[1] = -ab[1];

        }
        else if (eq[0] == '-' && minusCount == 1)
        {
            ab[0] = -ab[0];
        }
        else if (eq[0] != '-' && minusCount == 1)
        {
            ab[1] = -ab[1];
        }
        //Console.WriteLine(string.Join(", ", ab));

        a = ab[0];
        b = ab[1];
        x = (double)-b / a;
        Console.WriteLine("x = " + x);
    }
}
using System;
//• Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int min = int.MaxValue;
        int max = 0;
        int sum = 0;
        double avg = 0;
        for (int i = 1; i <= n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > max)//max
            {
                max = number;
            }
            if (number < min)//min
            {
                min = number;
            }
            sum += number;
        }
        avg = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}
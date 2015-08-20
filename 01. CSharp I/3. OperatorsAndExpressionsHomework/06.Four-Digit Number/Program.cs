using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a FOUR digit number. \nThe number has to have exactly 4 digits and cannot start with 0.");
        int a = Convert.ToInt32(Console.ReadLine());
        //int a = 1234;
        int first = (a / 1000) % 10;
        int second = (a / 100) % 10;
        int third = (a / 10) % 10;
        int fourth = (a / 1) % 10;
        Console.WriteLine("The sum of the digits is ({0}).", (first + second + third + fourth));
        Console.WriteLine("The the number in reversed order is ({3}{2}{1}{0}).", first, second, third, fourth);
        Console.WriteLine("The number with the last digit in the first position is ({3}{0}{1}{2}).", first, second, third, fourth);
        Console.WriteLine("The number with exchanged second and the third digits is ({0}{2}{1}{3}).", first, second, third, fourth);
    }
}
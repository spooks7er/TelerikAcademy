using System;
using System.Collections.Generic;

public class Program_old
{
    public static void Main_old()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        List<string> numbers = new List<string> { };
        
        for (int i = 0; i < n; i++)
        {
            string numero = Console.ReadLine();
            numbers.Add(numero);
        }

        //int s = 9;
        //string numero = "9369";
        //List<string> numbers = new List<string> { };
        //numbers.Add(numero);

        string binaryString = Convert.ToString(s, 2).PadLeft(5, '0');

        int count = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            long number = long.Parse(numbers[i]);

            string numBin = Convert.ToString(number, 2).PadLeft(64, '0');

            string first29bits = numBin.Substring(35, 29);

            for (int j = 29; j > 4; j--)
            {
                string slice = first29bits.Substring(j - 5, 5);

                if (slice == binaryString)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
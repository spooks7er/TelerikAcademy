using System;
using System.Numerics;

public class Task3
{
    public static void Main()
    {
        //System.IO.StreamReader reader = new System.IO.StreamReader("..\\..\\input.txt");
        //Console.SetIn(reader);

        string numberAsString = string.Empty;

        BigInteger product = 1;
        BigInteger productAfterTen = 1;

        int count = 0;

        while (true)
        {
            numberAsString = Console.ReadLine();

            if (numberAsString == "END")
            {
                break;
            }

            if (numberAsString == "0")
            {
                numberAsString = "1";
            }

            if (count % 2 == 0)
            {
                if (count < 10)
                {
                    product *= ProductOfDigits(numberAsString);
                }
                else
                {
                    productAfterTen *= ProductOfDigits(numberAsString);
                }
            }

            count++;
        }

        Console.WriteLine(product);

        if (count > 9)
        {
            Console.WriteLine(productAfterTen);
        }
    }

    public static BigInteger ProductOfDigits(string number)
    {
        BigInteger result = 1;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != '0')
            {
                result *= number[i] - '0';
            }
        }

        return result;
    }
}
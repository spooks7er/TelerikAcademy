using System;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ).
//• Each of the numbers that will be added could have up to  10 000  digits.

class Program
{
    static void Main(string[] args)
    {
        int[] n1 = { 6, 2, 8 ,5};// 5826 + 435 = 6261
        int[] n2 = { 5, 3, 4 };

        Console.WriteLine(AddTwoArraysAsNumbers(n1, n2));
    }

    public static string AddTwoArraysAsNumbers(int[] n1, int[] n2)
    {
        string result = string.Empty;

        int tempResult = 0;
        int oneInMind = 0;

        int lenMax = GetMax(n1.Length, n2.Length);
        int lenMin = GetMin(n1.Length, n2.Length);

        for (int i = 0; i < lenMax; i++)
        {
            if (i == lenMin)
            {
                if (n1.Length == lenMax)
                {
                    result += n1[i] + oneInMind;
                }
                else
                {
                    result += n2[i] + oneInMind;
                }
            }
            else
            {
                tempResult = n1[i] + n2[i] + oneInMind;

                if (tempResult >= 10)
                {
                    tempResult -= 10;
                    oneInMind = 1;
                }
                else
                {
                    oneInMind = 0;
                }
                result = result + tempResult;

                if (i == lenMax - 1 && oneInMind == 1)
                {
                    result += oneInMind;
                }
            }
        }

        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        result = new string(charArray);

        return result;
    }

    public static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
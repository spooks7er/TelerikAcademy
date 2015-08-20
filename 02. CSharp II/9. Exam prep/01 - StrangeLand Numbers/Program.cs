using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        //string[] numbersArr = { "f",
        //                        "bIN",
        //                        "oBJEC",
        //                        "mNTRAVL",
        //                        "lPVKNQ",
        //                        "pNWE",
        //                        "hT",
        //                      };

        //Dictionary<string, ulong> numbersDict = new Dictionary<string, ulong>()
        //{
        //    {"f",0},//1
        //    {"bIN",1},//3
        //    {"oBJEC",2},//5
        //    {"mNTRAVL",3},//7
        //    {"lPVKNQ",4},//6
        //    {"pNWE",5},//4
        //    {"hT",6},//2
        //};
        string number = Console.ReadLine();
        string numberDec = string.Empty;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == 'f')
            {
                numberDec += "0";
            }
            if (number[i] == 'b')
            {
                numberDec += "1";
            }
            if (number[i] == 'o')
            {
                numberDec += "2";
            }
            if (number[i] == 'm')
            {
                numberDec += "3";
            }
            if (number[i] == 'l')
            {
                numberDec += "4";
            }
            if (number[i] == 'p')
            {
                numberDec += "5";
            }
            if (number[i] == 'h')
            {
                numberDec += "6";
            }
        }

        BigInteger result = 0;
        int power = 0;
        for (int i = numberDec.Length - 1; i >= 0; i--)
        {
            int currentDigit = numberDec[i] - '0';

            result += currentDigit * Power(7, power);
            power++;
        }
        Console.WriteLine(result);
    }
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}
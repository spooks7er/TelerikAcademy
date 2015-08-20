using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
class Program
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\input.txt");
        //Console.SetIn(reader);

        string myString = "";// Console.ReadLine();
        List<string> numbers = new List<string> { };
        do
        {
            myString = Console.ReadLine();

            if (myString != "0" && myString != "END")
            {
                numbers.Add(myString);
            }
            else
            {
                numbers.Add("1");
            }

        } while (myString != "END");

        List<BigInteger> products = new List<BigInteger> { };
        List<BigInteger> products10 = new List<BigInteger> { };
        if (numbers.Count <= 10)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    BigInteger prod = 1;
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        if (numbers[i][j] != '0')
                        {
                            prod *= (numbers[i][j] - '0');
                        }
                    }
                    products.Add(prod);
                }
            }
        }
        else
        {
            for (int i = 0; i < numbers.Count - numbers.Count + 10; i++)
            {
                if (i % 2 == 0)
                {
                    BigInteger prod = 1;
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        if (numbers[i][j] != '0')
                        {
                            prod *= (numbers[i][j] - '0');
                        }
                    }
                    products.Add(prod);
                }
            }
            for (int i = 10; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    BigInteger prod = 1;
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        if (numbers[i][j] != '0')
                        {
                            prod *= (numbers[i][j] - '0');
                        }
                    }
                    products10.Add(prod);
                }
            }
        }

        BigInteger bigprod = 1;
        BigInteger bigprod10 = 1;
        if (numbers.Count <= 10)
        {
            foreach (BigInteger item in products)
            {
                bigprod *= item;
            }
            Console.WriteLine(bigprod);
        }
        else
        {
            foreach (BigInteger item in products)
            {
                bigprod *= item;
            }
            Console.WriteLine(bigprod);
            foreach (BigInteger item in products10)
            {
                bigprod10 *= item;
            }
            Console.WriteLine(bigprod10);
        }
    }
}
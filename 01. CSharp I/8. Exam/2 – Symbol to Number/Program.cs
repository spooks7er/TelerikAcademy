using System;
class Program
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        //int secret = 10;
        //string text = "C#1 is pretty easy exam@";

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122))
            {
                int ch = text[i];
                ch *= secret;
                ch += 1000;
                if (i % 2 == 0)
                {
                    double encoded = (double)ch / 100;
                    Console.WriteLine("{0:0.00}", encoded);
                }
                else
                {
                    ch *= 100;
                    Console.WriteLine(ch);
                }
            }
            else if (text[i] >= 48 && text[i] <= 57)
            {
                int ch = text[i];
                ch += secret;
                ch += 500;
                if (i % 2 == 0)
                {
                    double encoded = (double)ch / 100;
                    Console.WriteLine("{0:0.00}", encoded);
                }
                else
                {
                    ch *= 100;
                    Console.WriteLine(ch);
                }
            }
            else
            {
                if (text[i] != '@')
                {
                    int ch = text[i];
                    ch -= secret;
                    if (i % 2 == 0)
                    {
                        double encoded = (double)ch / 100;
                        Console.WriteLine("{0:0.00}", encoded);
                    }
                    else
                    {
                        ch *= 100;
                        Console.WriteLine(ch);
                    }
                }
            }
            if (text[i] == '@')
            {
                //stop the program
            }
        }
        //Console.WriteLine(count);
    }
}
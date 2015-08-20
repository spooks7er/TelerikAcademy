using System;

public class Task2
{
    public static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        //int secret = 10;
        //string text = "C#1 is pretty easy exam@";

        Encoder(secret, text);
    }

    private static void Encoder(int secret, string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122))
            {
                int character = text[i];
                character *= secret;
                character += 1000;

                EvenOrOdd(i, character);
            }
            else if (text[i] >= 48 && text[i] <= 57)
            {
                int character = text[i];
                character += secret;
                character += 500;

                EvenOrOdd(i, character);
            }
            else if (text[i] != '@')
            {
                int character = text[i];
                character -= secret;

                EvenOrOdd(i, character);
            }
        }
    }

    private static void EvenOrOdd(int index, int character)
    {
        if (index % 2 == 0)
        {
            double encoded = (double)character / 100;
            Console.WriteLine("{0:0.00}", encoded);
        }
        else
        {
            character *= 100;
            Console.WriteLine(character);
        }
    }
}
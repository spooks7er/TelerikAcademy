using System;
//....*******....
//...*...*...*...
//..*....*....*..
//.*.....*.....*.
//***************
//.*.....*.....*.
//..*....*....*..
//...*...*...*...
//....*..*..*....
//.....*.*.*.....
//......***......
//.......*.......
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 5;
        int h = (6 + ((n - 3) / 2) * 3);
        int w = n * 2 + 1;

        int topDots = (w - n) / 2;
        int bottomDots = (w - 1) / 2;
        Console.WriteLine(new string('.', topDots) + new string('*', n) + new string('.', topDots));

        for (int i = 0; i < topDots - 1; i++)
        {
            Console.WriteLine(new string('.', topDots - i - 1) + "*" + new string('.', topDots + i - 1) + "*" + new string('.', topDots + i - 1) + "*" + new string('.', topDots - i - 1));
        }

        Console.WriteLine(new string('*', w));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', i + 1) + "*" + new string('.', n - i - 2) + "*" + new string('.', n - i - 2) + "*" + new string('.', i + 1));
        }
        Console.WriteLine(new string('.', n) + "*" + new string('.', n));

    }
}
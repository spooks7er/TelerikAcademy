using System;
//.....*.....
//....***....
//...*.*.*...
//..*..*..*..
//.*...*...*.
//***********
//.*...*...*.
//..*..*..*..
//...*****...
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 39;
        int height = 6 + ((n - 3) / 2) * 3;
        int sails = (height / 3) * 2;
        int bot = height / 3;
        
        Console.WriteLine(new string('.', n) + '*' + new string('.', n));
        
        for (int i = 1; i < sails-1; i++)
        {
            Console.WriteLine(new string('.', n - i) + '*' + new string('.', i - 1) + '*' + new string('.', i - 1) + '*' + new string('.', n - i));
        }
        
        Console.WriteLine(new string('*', 2 * n + 1));

        for (int i = 1; i <= bot - 1; i++)
        {
            Console.WriteLine(new string('.', n - (n - i)) + '*' + new string('.', n - i - 1) + '*' + new string('.', n - i - 1) + '*' + new string('.', n - (n - i)));
        }
        Console.WriteLine(new string('.', (n / 2)+1) + new string('*', n) + new string('.', (n / 2)+1));
    }
}
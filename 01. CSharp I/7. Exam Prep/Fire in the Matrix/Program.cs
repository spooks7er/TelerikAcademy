using System;
//...##...
//..#..#..
//.#....#.
//#......#
//#......#
//.#....#.
//--------
//\\\\////
//.\\\///.
//..\\//..
//...\/...
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 76;
        for (int i = 0; i < n /2; i++)
        {
            Console.WriteLine(new string('.', n / 2 - (i+1)) + '#' + new string('.', 2*i) + '#' + new string('.', n / 2 - (i+1)));
        }

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine(new string('.', i) + '#' + new string('.', (n - 2) - (2 * i)) + '#' + new string('.', i));
        }
        Console.WriteLine(new string('-', n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', i) + new string('\\', (n / 2) - i) + new string('/', (n / 2) - i) + new string('.', i));
        }
    }
}
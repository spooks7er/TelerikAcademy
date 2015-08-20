using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        long[] path = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(long.Parse).ToArray();

        //long[] path = { 4, 17, 4, 2, 7, 11, 3, 2 };
        string winner = string.Empty;
        BigInteger MollyFlowers = 0;

        BigInteger DollyFlowers = 0;

        for (long i = 0, j = path.Length - 1; ; i++, j--)
        {
            // Molly -->
            if (i > path.Length - 1)
            {
                i %= path.Length;
            }
            long MollyJump = path[i] - 1;

            // Dolly <--
            if (j < 0)
            {
                j %= path.Length;
                j += path.Length;
            }
            long DollyJump = path[j] - 1;

            // calculating flowers
            if (i == j)
            {
                MollyFlowers += path[i] / 2;
                DollyFlowers += path[j] / 2;
                path[i] %= path[i];
            }
            else
            {
                MollyFlowers += path[i];
                DollyFlowers += path[j];

                if (path[i] == 0 || path[j] == 0)
                {
                    if (path[i] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (path[j] == 0)
                    {
                        winner = "Molly";
                    }
                    if (path[i] == 0 && path[j] == 0)
                    {
                        winner = "Draw";
                    }
                    break;
                }
            }
            //
            path[i] = 0;
            path[j] = 0;
            i += MollyJump;
            j -= DollyJump;
        }

        Console.WriteLine(winner);
        Console.WriteLine("{0} {1}", MollyFlowers, DollyFlowers);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] p1 = new int[3];
        int[] p2 = new int[3];
        Console.WriteLine("Enter 2 polynomials each with 3 coefficients");

        Console.WriteLine("Enter the coefficients of polynomial 1, each on a new line.");
        for (int i = 0; i < 3; i++)
        {
            p1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the coefficients of polynomial 2, each on a new line.");
        for (int i = 0; i < 3; i++)
        {
            p2[i] = int.Parse(Console.ReadLine());
        }

        //int[] p1 = {1,2,3};
        //int[] p2 = {5,6,9};

        Console.WriteLine("The subtracted polynomials are equal to:");
        Console.WriteLine(string.Join(", ", PolynomialSubs(p1, p2)));

        Console.WriteLine("The multiplied polynomials are equal to:");
        Console.WriteLine(string.Join(", ", PolynomialMult(p1, p2)));
    }

    public static int[] PolynomialMult(int[] pol1, int[] pol2)
    {
        int[] newPol = new int[3];

        for (int i = 0; i < newPol.Length; i++)
        {
            newPol[i] = (pol1[i] * pol2[0]) + (pol1[i] * pol2[1]) + (pol1[i] * pol2[2]);
        }
        return newPol;
    }

    public static int[] PolynomialSubs(int[] pol1, int[] pol2)
    {
        int[] newPol = new int[3];

        for (int i = 0; i < newPol.Length; i++)
        {
            newPol[i] = pol1[i] - pol2[i];
        }
        return newPol;
    }
}
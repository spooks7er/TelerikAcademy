using System;
//Write a method that adds two polynomials.
//• Represent them as arrays of their coefficients
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
        Console.WriteLine("The added polynomials are equal to:");
        
        Console.WriteLine(string.Join(", ", PolynomialAdd(p1, p2)));
    }

    public static int[] PolynomialAdd(int[] pol1, int[] pol2)
    {
        int[] newPol = new int[3];

        for (int i = 0; i < newPol.Length; i++)
        {
            newPol[i] = pol1[i] + pol2[i];
        }
        return newPol;
    }
}
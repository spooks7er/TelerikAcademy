using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        float input = 0.0f;
        bool IsFloat;
        do
        {
            Console.Write("Enter any floating point number: ");
            IsFloat = float.TryParse(Console.ReadLine(), out input);
            if (!IsFloat)
                Console.WriteLine("Invalid floating point number. Try again.");
        } while (!IsFloat);
        bool isNegative = false;
        if (input < 0.0f)
        {
            input = -input;
            isNegative = true;
        }

        byte mantissa = 127;
        double dInput = input;
        if (input > 2.0f)
        {
            while (dInput >= 2.0)
            {
                mantissa++;
                dInput = dInput / 2.0d;
            }
        }
        else
        {
            while (dInput < 1.0)
            {
                mantissa--;
                dInput = dInput * 2.0d;
            }
        }
        dInput = dInput - 1.0f;
        StringBuilder significant = new StringBuilder();
        for (int i = 0; i < 23; i++)
        {
            dInput = dInput * 2;
            if (dInput >= 1.0d)
            {
                significant.Append('1');
                dInput = dInput - 1.0f;
            }
            else
            {
                significant.Append('0');
            }
        }
        Console.WriteLine("Sign: {0}, mantissa: {1}, exponent: {2}", (isNegative ? "-" : "+"),
                                    Convert.ToString(mantissa, 2).PadLeft(8, '0'), significant);
    }
}
using System;

public class Task5
{
    public static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        string binaryString = Convert.ToString(s, 2).PadLeft(5, '0');

        for (int i = 0; i < n; i++)
        {
            string numberAsString = Console.ReadLine();
            long number = long.Parse(numberAsString);
            count += FindOccurances(number, binaryString);
        }

        Console.WriteLine(count);
    }

    private static int FindOccurances(long number, string binaryString)
    {
        int count = 0;
        string numBin = Convert.ToString(number, 2).PadLeft(64, '0');

        string first29bits = numBin.Substring(35, 29);

        for (int j = 29; j > 4; j--)
        {
            string slice = first29bits.Substring(j - 5, 5);

            if (slice == binaryString)
            {
                count++;
            }
        }
        return count;
    }
}
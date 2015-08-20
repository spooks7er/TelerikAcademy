﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        foreach (int i in UniqueRandom(1, n))
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }

    static IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
    {
        List<int> candidates = new List<int>();
        for (int i = minInclusive; i <= maxInclusive; i++)
        {
            candidates.Add(i);
        }
        Random rnd = new Random();
        while (candidates.Count > 0)
        {
            int index = rnd.Next(candidates.Count);
            yield return candidates[index];
            candidates.RemoveAt(index);
        }
    }
}
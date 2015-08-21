// Problem 21.* Combinations of set

// Write a program that reads two numbers N and K and generates 
// all the combinations of K distinct elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsOfSet
{
    static void Main()
    {
        Console.WriteLine("Program that generate all the combinations of K distinct elements from the set [1..N].");
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K= ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[10];
        comb(1, k, n, arr, 0);

    }
    private static void printToConsole(int i, int[] taken)
    {
        Console.Write("{");
        for (int x = 0; x < i; x++)
        {
            if (x == i - 1)
            {
                Console.Write(taken[x]);
            }
            else
            {
                Console.Write("{0}, ", taken[x]);
            }
        }
        Console.WriteLine("}");
    }
    private static void comb(int y, int k, int n, int[] taken, int after)
    {
        if (y > k)
        {
            return;
        }
        for (int i = after + 1; i <= n; i++)
        {
            taken[y - 1] = i;
            if (y == k)
            {
                printToConsole(y, taken);
            }
            comb(y + 1, k, n, taken, i);
        }

    }
}


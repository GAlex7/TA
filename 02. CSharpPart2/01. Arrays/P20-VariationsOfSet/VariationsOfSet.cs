// Problem 20.* Variations of set

// Write a program that reads two numbers N and K and generates 
// all the variations of K elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;

class VariationsOfSet
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program that generate all the variations of K elements from the set [1..N].");
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K= ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[10];
        variate(0,k,n, arr);

    }
    private static void printToConsole(int i, int[] taken)
    {
        Console.Write("{");
        for (int x = 0; x < i; x++)
        {
            if (x == i - 1)
            {
                Console.Write(taken[x] + 1);
            }
            else
            {
                Console.Write("{0}, ", taken[x] + 1);
            }
        }
        Console.WriteLine("}");
    }
    private static void variate(int y,int k,int n,int[] taken)
    {
        if (y >= k)
        {
            printToConsole(y, taken);
            return;
        }
        for (int i = 0; i < n; i++)
        {
            taken[y] = i;
            variate(y + 1,k,n,taken);
        }

    }
}
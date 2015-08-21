// Problem 19.* Permutations of set

// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;
using System.Collections.Generic;
using System.Linq;

class PermutationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("Please enter int N to generate permutations. N= ");
        int n = int.Parse(Console.ReadLine());
        int lev = -1;
        int[] val = new int[n];
        Permutation(n - 1, lev, val, n);
    }

    public static void Permutation(int k, int level, int[] value, int n)
    {
        level++;
        value[k] = level;

        if (level == n)
        {
            Console.Write("{");
            Console.Write(String.Join(", ", value));
            Console.WriteLine("}");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (value[i] == 0)
                {
                    Permutation(i, level, value, n);
                }
            }
        }
        level--;
        value[k] = 0;
    }
}
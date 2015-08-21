// Problem 8. Catalan Numbers
// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the n-th Catalan number by given n (1 <= n <= 100).

using System;

class CatalanNumbers
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        double result = 1;
        for (int i = 2; i <= numN; i++)
        {
            result *= (double)(numN + i) / i;
        }
        Console.WriteLine(result);
    }
}
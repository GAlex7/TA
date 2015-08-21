// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// Write a program that, for a given two integer numbers n and x, 
// calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;
class CalculateSumWithFactorial
{
    public static long factorial(long a)
    {
        if (a <= 1)
        {
            return 1;
        }
        else
        {
            long c = a * factorial(a - 1);
            return c;
        }
    }

    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numX = int.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 0; i < numN; i++)
        {
            sum = sum + Convert.ToDouble((factorial(i + 1)) / Math.Pow(numX, i+1));
        }
        Console.WriteLine("{0:f5}",sum);
    }
}
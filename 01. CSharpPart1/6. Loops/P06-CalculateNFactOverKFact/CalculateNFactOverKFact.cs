// Problem 6. Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;
class CalculateNFactOverKFact
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        double result = 1;
        for (int i = (numN-(numN-numK)+1); i <= numN; i++)
        {
            result *= i; 
        }
        Console.WriteLine(result);
    }
}
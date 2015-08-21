// Problem 18.* Trailing Zeroes in N!
// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;
class TrailingZeroesInFact
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long zeros = 0;
        int stepen = 1;
        while (n / (long)Math.Pow(5, stepen) > 0)
        {
            zeros += n / (long)Math.Pow(5, stepen);
            stepen++;
        }
        Console.WriteLine(zeros);
    }
}
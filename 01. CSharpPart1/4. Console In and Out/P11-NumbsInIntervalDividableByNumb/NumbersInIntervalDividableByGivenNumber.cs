// Problem 11.* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints 
// how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int ends = int.Parse(Console.ReadLine());
        int p = 0;
        int divider = 5;
        for (int i = start; i < ends + 1; i++)
        {
            if (i % divider == 0)
            {
                p += 1;
            }
        }
        Console.WriteLine(p);
    }
}
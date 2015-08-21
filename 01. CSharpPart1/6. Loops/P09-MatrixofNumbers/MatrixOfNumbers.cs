// Problem 9. Matrix of Numbers
// Write a program that reads from the console a positive integer number n (1 = n = 20) and
// prints a matrix like in the examples below. Use two nested loops.

using System;
class MatrixOfNumbers
{
    static void Main()
    {
        byte numN = byte.Parse(Console.ReadLine());
        for (int i = 0; i < numN; i++)
        {
            for (int j = 1; j <= numN; j++)
            {
                Console.Write("{0,3}",i+j);
            }
            Console.WriteLine();
        }
    }
}
﻿// Problem 11. Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max (min != max) and 
// prints n random numbers in the range [min...max].

using System;
class RandomNumbsInGivenRange
{
    static void Main(string[] args)
    {
        int numN = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < numN; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}
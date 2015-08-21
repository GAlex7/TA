﻿//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Please enter a real number N1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter another real number N2: ");
        double b = Convert.ToDouble(Console.ReadLine());
        bool equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("N1 =? N2 --> " + equal);
    }
}
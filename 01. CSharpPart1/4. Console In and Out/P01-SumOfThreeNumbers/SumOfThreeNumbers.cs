// Problem 1. Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;
class SumOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float a = float.Parse(Console.ReadLine().Replace('.', ','));
        float b = float.Parse(Console.ReadLine().Replace('.', ','));
        float c = float.Parse(Console.ReadLine().Replace('.', ','));
        float sum = a + b + c;
        Console.WriteLine(sum);
    }
}
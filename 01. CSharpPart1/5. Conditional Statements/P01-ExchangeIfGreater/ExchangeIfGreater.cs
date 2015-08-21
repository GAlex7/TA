// Problem 1. Exchange If Greater
// Write an if-statement that takes two double variables a and b and exchanges their values 
// if the first one is greater than the second one. 
// As a result print the values a and b, separated by a space.

using System;
using System.Globalization;
using System.Threading;
class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        double numA = double.Parse(Console.ReadLine().Replace('.', ','));
        double numB = double.Parse(Console.ReadLine().Replace('.', ','));
        if (numA > numB)
        {
            double numC = numB;
            numB = numA;
            numA = numC;
        }
        Console.WriteLine("{0} {1}", numA, numB);
    }
}
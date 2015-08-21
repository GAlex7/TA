// Problem 7. Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, separated by a space), 
// calculates and prints their sum.


using System;
using System.Globalization;
using System.Threading;
class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string input = Console.ReadLine();
        input = input.Replace('.', ',');
        double sum = 0;
        string[] numStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < numStr.Length; i++)
        {
            sum += double.Parse(numStr[i]);
        }
        Console.WriteLine(sum);
    }
}

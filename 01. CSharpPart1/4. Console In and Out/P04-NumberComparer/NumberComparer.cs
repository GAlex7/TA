// Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            float a = float.Parse(Console.ReadLine().Replace('.', ','));
            float b = float.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine(a>b?a:b);
        }
    }
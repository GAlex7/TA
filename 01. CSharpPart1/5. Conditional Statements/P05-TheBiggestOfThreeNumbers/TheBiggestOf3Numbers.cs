// Problem 5. The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float numA = float.Parse(Console.ReadLine().Replace('.', ','));
        float numB = float.Parse(Console.ReadLine().Replace('.', ','));
        float numC = float.Parse(Console.ReadLine().Replace('.', ','));
        if (numA > numB)
        {
            if (numA > numC)
            {
                Console.WriteLine(numA);
            }
            else
            {
                Console.WriteLine(numC);
            }
        }
        else if (numB > numC)
        {
            Console.WriteLine(numB);
        }
        else
        {
            Console.WriteLine(numC);
        }
    }
}
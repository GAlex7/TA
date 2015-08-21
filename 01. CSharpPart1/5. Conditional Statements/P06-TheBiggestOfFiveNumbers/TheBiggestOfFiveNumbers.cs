// Problem 6. The Biggest of Five Numbers
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float num1 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num2 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num3 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num4 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num5 = float.Parse(Console.ReadLine().Replace('.', ','));
        if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
        {
              Console.WriteLine(num1);
        }
        else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
        {
            Console.WriteLine(num2);
        }
        else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
        {
                       Console.WriteLine(num3);
        }
        else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
        {
            Console.WriteLine(num4);
        }
        else
        {
            Console.WriteLine(num5);
        }
    }
}
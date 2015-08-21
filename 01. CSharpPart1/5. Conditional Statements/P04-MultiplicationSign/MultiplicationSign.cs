// Problem 4. Multiplication Sign
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
// without calculating it.
// Use a sequence of if operators.

using System;
using System.Globalization;
using System.Threading;
class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float numA = float.Parse(Console.ReadLine().Replace('.', ','));
        float numB = float.Parse(Console.ReadLine().Replace('.', ','));
        float numC = float.Parse(Console.ReadLine().Replace('.', ','));
        if (numA == 0 || numB == 0 || numC == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int countNegativeNums = 0;
            if (numA < 0)
            {
                countNegativeNums += 1;
            }
            if (numB < 0)
            {
                countNegativeNums += 1;
            }
            if (numC < 0)
            {
                countNegativeNums += 1;
            }
            if (countNegativeNums % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
// Problem 7. Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

using System;
using System.Globalization;
using System.Threading;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float num1 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num2 = float.Parse(Console.ReadLine().Replace('.', ','));
        float num3 = float.Parse(Console.ReadLine().Replace('.', ','));
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("{0} ", num1);
                if (num2 > num3)
                {
                    Console.WriteLine("{0} {1}", num2, num3);
                }
                else
                {
                    Console.WriteLine("{0} {1}", num3, num2);
                }
            }
            else
            {
                Console.Write("{0} ", num3);
                if (num1 > num2)
                {
                    Console.WriteLine("{0} {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} {1}", num2, num1);
                }
            }
        }
        else if (num2 > num3)
        {
            Console.Write("{0} ", num2);
            if (num1 > num3)
            {
                Console.WriteLine("{0} {1}", num1, num3);
            }
            else
            {
                Console.WriteLine("{0} {1}", num3, num1);
            }
        }
        else
        {
            Console.Write("{0} ", num3);
            if (num1 > num2)
            {
                Console.WriteLine("{0} {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} {1}", num2, num1);
            }
        }
    }
}
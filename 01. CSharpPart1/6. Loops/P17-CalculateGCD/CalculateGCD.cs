// Problem 17.* Calculate GCD
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;
class CalculateGCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a<0)
        {
            a *= -1;
        }
        if (b<0)
        {
            b *= -1;
        }
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine("GCD is {0}",a);

        //    function gcd(a, b)
        //while a ≠ b
        //    if a > b
        //       a := a − b
        //    else
        //       b := b − a
        //return a
    }
}
// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please enter a number : ");
        int num = int.Parse(Console.ReadLine());
        bool isOdd = !(num % 2 == 0);
        Console.WriteLine("This number is odd --> {0}.", isOdd);
    }
}

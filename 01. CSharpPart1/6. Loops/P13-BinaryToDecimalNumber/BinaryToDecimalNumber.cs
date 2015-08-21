// Problem 13. Binary to Decimal Number
// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string numAsString = Console.ReadLine();
        long num = 0;
        for (int i = 0; i < numAsString.Length; i++)
        {
            if (numAsString[i] == '1')
            {
                num += (long)Math.Pow(2, numAsString.Length - i - 1);
            }
        }
        Console.WriteLine(num);
    }
}
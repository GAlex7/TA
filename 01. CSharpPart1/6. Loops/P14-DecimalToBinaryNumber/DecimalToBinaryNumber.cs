// Problem 14. Decimal to Binary Number
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int stepen = 0;
        // How many bits is needed
        while ((long)Math.Pow(2, stepen + 1) - 1 < num)
        {
            stepen++;
        }

        // Convert to string
        string numAsString = "";
        long x = num;
        for (int i = stepen; i >= 0; i--)
        {
            if (x >= (long)Math.Pow(2, i))
            {
                numAsString += "1";
                x -= (long)Math.Pow(2, i);
            }
            else
            {
                numAsString += "0";
            }
        }
        Console.WriteLine(numAsString);
    }
}
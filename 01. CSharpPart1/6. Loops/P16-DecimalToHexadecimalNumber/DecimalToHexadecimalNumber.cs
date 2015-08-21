// Problem 16. Decimal to Hexadecimal Number
// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int stepen = 0;
        // How many bits is needed
        while ((long)Math.Pow(16, stepen + 1) - 1 < num)
        {
            stepen++;
        }

        // Convert to string
        string numAsString = "";
        long x = num;

        for (int i = stepen; i >= 0; i--)
        {
            char charValue = ' ';
            long y = (long)Math.Pow(16, i);
            if (x / y < 10)
            {
                charValue = (char)(x / y + 48);
            }
            else
            {
                charValue = (char)(x / y + 87);
            }
            numAsString += charValue;
            x -= (long)Math.Pow(16, i) * (x / y);
        }
        Console.WriteLine(numAsString.ToUpper());
    }
}
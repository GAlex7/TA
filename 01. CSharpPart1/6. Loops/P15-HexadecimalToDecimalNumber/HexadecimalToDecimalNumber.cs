// Problem 15. Hexadecimal to Decimal Number
// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        // Console.OutputEncoding = System.Text.Encoding.Unicode;
        string numAsString = Console.ReadLine();
        numAsString = numAsString.ToLower();
        long num = 0, charValue = 0;
        for (int i = 0; i < numAsString.Length; i++)
        {
            if ((numAsString[i] >= 'a') & (numAsString[i] <= 'f'))  // code 'a' = 97
            {                                                       // code '1' = 49
                charValue = numAsString[i] - 87;
            }
            else
            {
                charValue = numAsString[i] - 48;
            }
            num += (long)Math.Pow(16, numAsString.Length - i - 1) * charValue;
        }
        Console.WriteLine(num);
    }
}
// Problem 4. Hexadecimal to decimal

// Write a program to convert hexadecimal numbers to their decimal representation.

namespace P04_HexadecimalToDecimal
{
    using System;
    using System.Text;

    class HexadecimalToDecimal
    {
        static long HexToDec(string hexNumb)
        {
            long numb = 0;
            hexNumb = hexNumb.ToLower();
            long charValue = 0;
            for (int i = 0; i < hexNumb.Length; i++)
            {
                if ((hexNumb[i] >= 'a') & (hexNumb[i] <= 'f'))  
                {                                               
                    charValue = hexNumb[i] - 'a' + 10;
                }
                else
                {
                    charValue = hexNumb[i] - '1' + 1;
                }
                numb += (long)Math.Pow(16, hexNumb.Length - i - 1) * charValue;
            }
            return numb;
        }
        static void Main()
        {
            Console.Write("Please enter hexadecimal number: ");
            string hex = Console.ReadLine();
            Console.WriteLine("It's equal to {0} dec.",HexToDec(hex));
        }
    }
}

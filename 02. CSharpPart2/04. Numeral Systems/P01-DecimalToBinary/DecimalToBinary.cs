// Problem 1. Decimal to binary

// Write a program to convert decimal numbers to their binary representation.

namespace P01_DecimalToBinary
{
    using System;
    using System.Text;

    public class DecimalToBinary
    {
        public static string DecToBin(long decNumb)
        {
            int stepen = 0;
            // How many bits is needed
            while ((long)Math.Pow(2, stepen + 1) - 1 < decNumb)
            {
                stepen++;
            }

            // Convert to string
            StringBuilder numAsString = new StringBuilder();
            long x = decNumb;
            for (int i = stepen; i >= 0; i--)
            {
                if (x >= (long)Math.Pow(2, i))
                {
                    numAsString.Append(1);
                    x -= (long)Math.Pow(2, i);
                }
                else
                {
                    numAsString.Append(0);
                }
            }
            return numAsString.ToString();
        }

        static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(num));
        }
    }
}

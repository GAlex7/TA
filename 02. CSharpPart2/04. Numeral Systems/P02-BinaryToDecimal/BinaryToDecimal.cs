// Problem 2. Binary to decimal

// Write a program to convert binary numbers to their decimal representation.

namespace P02_BinaryToDecimal
{
    using System;
    using System.Text;

    public class BinaryToDecimal
    {
        public static long BinToDec(string binNumb)
        {
            long numb = 0;
            for (int i = 0; i < binNumb.Length; i++)
            {
                if (binNumb[i] == '1')
                {
                    numb += (long)Math.Pow(2, binNumb.Length - i - 1);
                }
            }
            return numb;
        }

        static void Main()
        {
            Console.Write("Please enter a binary number: ");
            string numAsString = Console.ReadLine();
            Console.WriteLine(BinToDec(numAsString));
        }
    }
}

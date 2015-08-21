// Problem 6. binary to hexadecimal

// Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace P06_BinaryToHexadecimal
{
    using System;
    using System.Text;
    using P02_BinaryToDecimal;
    using P03_DecimalToHexadecimal;

    class BinaryToHexadecimal
    {
        static string BinToHex(string binNumb)
        {
            StringBuilder hexNumb = new StringBuilder();
            string lastFourBits = string.Empty;
            while (binNumb.Length > 0)
            {
                if (binNumb.Length >= 4)
                {
                    lastFourBits = binNumb.Substring(binNumb.Length - 4);
                    binNumb = binNumb.Remove(binNumb.Length - 4);
                }
                else
                {
                    lastFourBits = binNumb;
                    binNumb = string.Empty;
                }
                hexNumb.Insert(0,DecimalToHexadecimal.DecToHex(BinaryToDecimal.BinToDec(lastFourBits)));
            }
            return hexNumb.ToString();
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter binary number: ");
            string bin = Console.ReadLine();
            Console.WriteLine(BinToHex(bin));
        }
    }
}

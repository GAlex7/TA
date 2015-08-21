// Problem 5. Hexadecimal to binary

// Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace P05_HexadecimalToBinary
{
    using System;
    using System.Text;
    using P01_DecimalToBinary;

    class HexadecimalToBinary
    {
        static string HexToBin(string hexNumb)
        {
            hexNumb = hexNumb.ToLower();
            StringBuilder binNumb = new StringBuilder();
            for (int i = 0; i < hexNumb.Length; i++)
            {
                if (hexNumb[i] >= 'a' && hexNumb[i] <= 'f')
                    binNumb.Append(DecimalToBinary.DecToBin(hexNumb[i] - 'a' + 10));
                else binNumb.Append(DecimalToBinary.DecToBin(hexNumb[i] - '0'));
            }
            return binNumb.ToString();
        }
        static void Main()
        {
            Console.Write("Please enter hexadecimal number: ");
            string hex = Console.ReadLine();
            Console.WriteLine("It's equal to {0} bin.", HexToBin(hex));
        }
    }
}

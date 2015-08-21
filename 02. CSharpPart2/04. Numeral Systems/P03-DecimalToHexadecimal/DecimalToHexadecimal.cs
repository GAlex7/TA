// Problem 3. Decimal to hexadecimal

// Write a program to convert decimal numbers to their hexadecimal representation.

namespace P03_DecimalToHexadecimal
{
    using System;
    using System.Text;

    public class DecimalToHexadecimal
    {
        public static string DecToHex(long numb)
        {
            StringBuilder hexNumb = new StringBuilder();
            int stepen = 0;
            // How many bits is needed
            while ((long)Math.Pow(16, stepen + 1) - 1 < numb)
            {
                stepen++;
            }

            // Convert to string
            long x = numb;
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
                hexNumb.Append(charValue);
                x -= (long)Math.Pow(16, i) * (x / y);
            }
            return hexNumb.ToString().ToUpper();
        }
        static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            long numb = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToHex(numb));
        }
    }
}

// Problem 7. Reverse number

// Write a method that reverses the digits of given decimal number.
// Example:

// input	output
// 256  	652
// 123.45	54.321


namespace P07_ReverseNumber
{
    using System;
    using System.Text;

    public class ReverseNumber
    {
        public static decimal ReverseNumb(decimal n)
        {
            string sign = string.Empty;
            if (n < 0)
            {
                sign = "-";
                n *= -1;
            }
            string nAsStr = n.ToString();
            var xAsStr = new StringBuilder(nAsStr.Length);
            xAsStr.Append(sign);
            for (int i = nAsStr.Length - 1; i >= 0; i--)
            {
                xAsStr.Append(nAsStr[i]);
            }
            return decimal.Parse(xAsStr.ToString());
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            decimal numb = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumb(numb));
        }
    }
}

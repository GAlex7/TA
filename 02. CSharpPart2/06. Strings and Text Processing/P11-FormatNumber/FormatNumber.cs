// Problem 11. Format number

// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

namespace P11_FormatNumber
{
    using System;
    using System.Text;

    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter an integer number : ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", numb);
            Console.WriteLine("{0,15:X}", numb);
            Console.WriteLine("{0,15:P}", numb / 100.0);
            Console.WriteLine("{0,15:E}", numb);
        }
    }
}

// Problem 10. Unicode characters

// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.
// Example:

// input	output
// Hi!	    \u0048\u0069\u0021

namespace P10_UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                Console.Write(String.Format("\\u{0:X4}", (int)ch));
            }
            Console.WriteLine();
        }
    }
}

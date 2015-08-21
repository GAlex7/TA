// Problem 2. Reverse string

// Write a program that reads a string, reverses it and prints the result at the console.
// Example:

// input	output
// sample	elpmas

namespace P02_ReverseString
{
    using System;
    using System.Text;

    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            var output = new StringBuilder();
            foreach (char ch in input)
            {
                output.Insert(0, ch);
            }
            Console.WriteLine(output.ToString());
        }
    }
}

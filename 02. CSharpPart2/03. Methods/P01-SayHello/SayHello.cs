// Problem 1. Say Hello

// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.
// Example:

// input	output
// Peter	Hello, Peter!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SayHello
{
    class SayHello
    {
        public static void SayHi()
        {
            Console.Write("What's Your name? ");
            string name = Console.ReadLine();
            name = string.Concat(name[0].ToString().ToUpper(),
                          name.Substring(1, name.Length - 1));
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            SayHi();
        }
    }
}

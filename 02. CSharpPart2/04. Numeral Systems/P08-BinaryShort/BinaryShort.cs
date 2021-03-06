﻿// Problem 8. Binary short

// Write a program that shows the binary representation of given 16-bit 
// signed integer number (the C# type short).

namespace P08_BinaryShort
{
    using System;

    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Please, enter a 16-bit signed integer (short): ");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}
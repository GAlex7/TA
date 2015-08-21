// Problem 1. Leap year

// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.


namespace P01_LeapYear
{
    using System;

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Please enter an year: ");
            int input = int.Parse(Console.ReadLine());
            if (input % 4 == 0)
                Console.WriteLine("This year is leap.");
            else Console.WriteLine("This year isn't leap.");
        }
    }
}

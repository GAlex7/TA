// Problem 3. Day of week

// Write a program that prints to the console which day of the week is today.
// Use System.DateTime;

namespace P03_DayOfWeek
{
    using System;

    class DayOfWeek
    {
        static void Main()
        {
            var nowIs = DateTime.Now;
            Console.WriteLine("Today is {0}.",nowIs.DayOfWeek);
        }
    }
}

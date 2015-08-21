// Problem 16. Date difference

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
// Example:

// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2006
// Distance: 4 days

namespace P16_DateDifference
{
    using System;
    using System.Globalization;

    class DateDifference
    {
        static void Main()
        {
            string format = "d.M.yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            Console.Write("Enter the first date  ({0}): ", format);
            DateTime first = DateTime.ParseExact(Console.ReadLine(), format, provider);

            Console.Write("Enter the second date ({0}): ", format);
            DateTime second = DateTime.ParseExact(Console.ReadLine(), format, provider);

            Console.WriteLine("Distance: {0} days", (first > second ? first - second : second - first).TotalDays);
        }
    }
}

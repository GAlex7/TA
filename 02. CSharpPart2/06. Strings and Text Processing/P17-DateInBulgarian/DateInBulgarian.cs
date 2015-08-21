// Problem 17. Date in Bulgarian

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
// prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace P17_DateInBulgarian
{
    using System;
    using System.Globalization;

    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            string format = "d.M.yyyy H:m:s"; //day.month.year hour:minute:second
            CultureInfo provider = CultureInfo.InvariantCulture;

            Console.Write("Enter the date and time ({0}): ", format);
            DateTime first = DateTime.ParseExact(Console.ReadLine(), format, provider);

            first = first.AddHours(6).AddMinutes(30);

            format = "dd.MM.yyyy hh:mm:ss - dddd";

            Console.WriteLine("\nThe date and time after 6 hours and 30 minutes will be: ");
            Console.WriteLine(first.ToString(format, CultureInfo.CreateSpecificCulture("bg-BG")));

        }
    }
}

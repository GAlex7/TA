// Problem 19. Dates from text in Canada

// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

namespace P19_DatesFromTextInCanada
{
    using System;
    using System.Threading;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();  
                       
            string pattern = @"[\d]{2}.[\d]{2}.[\d]{4}";
            string format = "dd.MM.yyyy";
            CultureInfo provider = Thread.CurrentThread.CurrentCulture;
            
            foreach (var word in Regex.Matches(text, pattern))
            {
                try
                {
                    DateTime check = DateTime.ParseExact(word.ToString(), format, provider);
                    Console.WriteLine(check.ToShortDateString());
                }
                catch (FormatException)
                {
                    continue;
                }
            }
        }
    }
}

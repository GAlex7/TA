// Problem 5. Workdays

// Write a method that calculates the number of workdays between today and given date,
// passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of 
// public holidays specified preliminary as array.


namespace P05_Workdays
{
    using System;
    using System.Collections.Generic;

    class Workdays
    {
        static List<DateTime> holyDays = new List<DateTime>()
        {
            new DateTime(2015, 1, 1),
            new DateTime(2015, 3, 2),
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10), 
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 9, 21),
            new DateTime(2015, 9, 22),
            new DateTime(2015,12,24),
            new DateTime(2015,12,25),
            new DateTime(2015,12,31)
        };

        static int WorkDaysBetwen(DateTime startDate, DateTime endDate)
        {
            DateTime currentDate = startDate;
            if (startDate > endDate)
            {
                //swap
                startDate = endDate;
                endDate = currentDate;
                currentDate = startDate;
            }
            int counter = 0;
            while (currentDate <= endDate)
            {
                if (!holyDays.Contains(currentDate) &&
                    currentDate.DayOfWeek != DayOfWeek.Saturday &&
                    currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
                currentDate = currentDate.AddDays(1);
            }
            return counter;
        }

        static void Main()
        {
            Console.Write("Please enter a date (dd.mm.yyyy): ");
            string input = Console.ReadLine();
            string[] myDate = input.Split('.');
            int[] endDateArr = new int[3];
            for (int i = 0; i < myDate.Length; i++)
            {
                endDateArr[i] = int.Parse(myDate[i]);
            }
            DateTime endDate = new DateTime(endDateArr[2], endDateArr[1], endDateArr[0]);
            DateTime startDate = DateTime.Now;
            Console.WriteLine("Workdays between {0:d.M.yyyy} and {1:d.M.yyyy} are {2}.",
                startDate,endDate,WorkDaysBetwen(startDate,endDate));
        }
    }
}

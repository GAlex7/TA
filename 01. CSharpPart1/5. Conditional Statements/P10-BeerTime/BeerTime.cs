// Problem 10.* Beer Time
// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
// a minute in range [00…59] and AM / PM designator) and prints beer time or 
// non-beer time according to the definition above or invalid time if the time cannot be parsed. 
// Note: You may need to learn how to parse dates and times.

using System;
class BeerTime
{
    static void Main()
    {
        DateTime startDrinking = Convert.ToDateTime("1:00 pm");
        DateTime stopDrinking = Convert.ToDateTime("3:00 am");
        DateTime beerTime;

        string input = Console.ReadLine();
        bool check = DateTime.TryParse(input, out beerTime);
        if (check)
        {
            int i = DateTime.Compare(beerTime, startDrinking);
            int j = DateTime.Compare(stopDrinking, beerTime);
            Console.WriteLine((i == 1 && j == -1) == true ? "beer time" : "non-beer time");
        }
        else
        {
            Console.WriteLine("Can't parse...");
        }

    }
}
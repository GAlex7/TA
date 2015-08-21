using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("How old are You now? ");
        short years = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("After 10 Years you'll be on " + (years + 10) + ".");
    }
}
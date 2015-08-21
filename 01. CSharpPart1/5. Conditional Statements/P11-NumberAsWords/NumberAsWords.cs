// Problem 11.* Number as Words
// Write a program that converts a number in the range [0…999] to words, 
// corresponding to the English pronunciation.

using System;
class NumberAsWords
{
    public static string NumbToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumbToWords(Math.Abs(number));

        string words = "";

        if ((number / 100) > 0)
        {
            words += NumbToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }

        return words;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(NumbToWords(num));
    }

}
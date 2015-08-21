// Problem 6. Sum integers

// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.
// Example:

// input            	output
// "43 68 9 23 318"	    461

namespace P06_SumIntegers
{
    using System;

    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sequence of positive integer values, separated by spaces:");
            string input = Console.ReadLine();
            string[] numbAsText = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numb = new int[numbAsText.Length];
            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = int.Parse(numbAsText[i]);
            }
            int sum = 0;
            foreach (var item in numb)
            {
                sum += item;
            }
            Console.WriteLine("The sum of them is: {0}",sum);
        }
    }
}

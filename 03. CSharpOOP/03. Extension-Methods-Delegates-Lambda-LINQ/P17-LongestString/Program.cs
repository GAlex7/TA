// Problem 17. Longest string

// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.

namespace P17_LongestString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = new[] 
            { 
                "Proba",
                "Another one",
                "The longest string in this array",
                "Xo xo xo",
            };

            var result =
                from x in input
                orderby x.Length
                select x;
            Console.WriteLine(result.Last().ToString());
        }
    }
}

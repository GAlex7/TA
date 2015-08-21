// Problem 6. Divisible by 7 and 3

// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace P06_DivisibleBy7and3
{
    using System;
    using System.Linq;

    class DivisibleBy7and3
    {
        static void Main()
        {
            var arr = new[] { 1, 5, 3, 7, 35, 42, 70, 235, 81, 63 };
            var result = arr
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .Select(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", result));

            var newResult=
                from item in arr
                where item % 3 == 0 
                where item % 7 == 0
                select item;

            Console.WriteLine(string.Join(", ", result));

        }
    }
}

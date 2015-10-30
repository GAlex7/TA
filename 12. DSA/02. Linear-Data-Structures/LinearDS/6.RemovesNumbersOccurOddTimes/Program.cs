namespace RemovesNumbersOccurOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var sequence = RemoveNumbersOccurdOddTimes(numbers);

            Console.WriteLine("New sequence without all numbers that occur odd number of times is: \n{0}: ", string.Join(", ", sequence));
        }

        private static ICollection<int> RemoveNumbersOccurdOddTimes(ICollection<int> numbers)
        {
            var encounters = new Dictionary<int, int>();
            var bestNumb = 0;
            var times = 0;

            foreach (var number in numbers)
            {
                if (!encounters.ContainsKey(number))
                {
                    encounters.Add(number, 0);
                }

                encounters[number]++;
                if (encounters[number] > times)
                {
                    times = encounters[number];
                    bestNumb = number;
                }
            }

            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (encounters[number] % 2 == 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}

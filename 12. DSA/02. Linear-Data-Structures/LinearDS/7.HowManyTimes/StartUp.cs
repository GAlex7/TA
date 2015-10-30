namespace HowManyTimes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "3, 4, 4, 2, 3, 3, 4, 3, 2";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            PrintHowManyTimesOccured(numbers);
        }

        private static void PrintHowManyTimesOccured(ICollection<int> numbers)
        {
            var encounters = new SortedDictionary<int, int>();
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

            foreach (var pair in encounters)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
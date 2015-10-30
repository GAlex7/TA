namespace LongestSubsequenceOfEquals
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
            var input = "7 1 4 2 3 1 2 1 8 2 1";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var longestSubsequence = GetLongestEqualSubsequence(numbers);

            foreach (var item in longestSubsequence)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

        public static ICollection<int> GetLongestEqualSubsequence(ICollection<int> numbers)
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
            for (int i = 0; i < times; i++)
            {
                result.Add(bestNumb);
            }

            return result;
        }
    }
}

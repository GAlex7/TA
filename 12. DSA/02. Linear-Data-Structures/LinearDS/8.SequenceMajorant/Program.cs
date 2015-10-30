namespace SequenceMajorant
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
            var input = "2, 2, 3, 3, 2, 3, 4, 3, 3";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var majorant = Majorant(numbers);

            Console.WriteLine(majorant == null ? "No Majorant!" : "The Majorant is " + majorant);
        }

        private static int? Majorant(ICollection<int> numbers)
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

            foreach (var pair in encounters)
            {
                if (pair.Value >= (numbers.Count / 2) + 1)
                {
                    return pair.Key;
                }
            }

            return null;
        }
    }
}
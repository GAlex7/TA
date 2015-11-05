namespace Counts
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
            var input = "3, 4, 4, -2.5, 3, 3, 4, 3, -2.5";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var sequence = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (var numb in sequence)
            {
                if (!dict.ContainsKey(numb))
                {
                    dict.Add(numb, 0);
                }

                dict[numb] += 1;
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}

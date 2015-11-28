namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var numbs = line.Split(' ').Select(int.Parse).ToList();
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbs.Count - 1; i++)
            {
                var current = numbs[i] + 1;
                if (!dict.ContainsKey(current))
                {
                    dict.Add(current, 0);
                }

                dict[current] += 1;
            }

            var result = 0;
            foreach (var item in dict)
            {
                int groups = item.Value / item.Key;

                if (item.Value % item.Key > 0)
                {
                    groups++;
                }

                result += groups * item.Key;
            }

            Console.WriteLine(result);
        }
    }
}

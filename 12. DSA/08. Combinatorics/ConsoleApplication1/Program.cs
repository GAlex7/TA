namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var input = @"9
2
2
44
2
2
2
444
2
2";
            Console.SetIn(new StringReader(input));

            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(current))
                {
                    dict.Add(current, 0);
                }

                dict[current] += 1;
            }

            var result = 0;
            foreach (var item in dict)
            {
                var x = item.Value < 3 ? 1 : 1 + item.Value / (item.Key + 1);
                //Console.WriteLine("{0} x = {1}",item.Key, x);
                result += x * (item.Key + 1);
            }
            Console.WriteLine(result);
        }
    }
}

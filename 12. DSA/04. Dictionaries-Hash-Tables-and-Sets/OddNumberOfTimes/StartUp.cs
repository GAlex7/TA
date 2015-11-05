namespace OddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "C#, SQL, PHP, PHP, SQL, SQL";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var sequence = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dict = new SortedDictionary<string, int>();

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
                if (pair.Value % 2 == 1)
                {
                    Console.Write("{0}, ", pair.Key);
                }
            }

            Console.WriteLine();
        }
    }
}

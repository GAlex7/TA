namespace Problem2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program2
    {
        public static void Main()
        {
            long[] numbs = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            int pos = 1;
            long abs = 0;
            long sum = 0;
            while (pos < numbs.Length)
            {
                abs = numbs[pos] > numbs[pos - 1] ? numbs[pos] - numbs[pos - 1] : numbs[pos - 1] - numbs[pos];
                pos += abs % 2 == 1 ? 1 : 2;
                sum += abs % 2 == 1 ? abs : 0;
            }

            Console.WriteLine(sum);
        }
    }
}
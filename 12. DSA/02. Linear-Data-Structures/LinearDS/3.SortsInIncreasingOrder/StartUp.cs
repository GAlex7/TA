namespace SortsInIncreasingOrder
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sequence of integers separated by single space:");

            // TODO Comment next 3 lines :)
            var input = "7 4 2 3 1 2 1 8 1";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var sequence = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList()
                .OrderBy(n => n);

            Console.WriteLine("Sorted sequence is: {0}: ", string.Join(", ", sequence));
        }
    }
}

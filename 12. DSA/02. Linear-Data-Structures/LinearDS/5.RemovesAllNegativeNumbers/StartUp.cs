namespace RemovesAllNegativeNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "7 -1 4 -2 3 -1 -2 1 8 -2 -1";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n >= 0)
                .ToList();

            Console.WriteLine("New sequence is: {0}: ", string.Join(", ", numbers));
        }
    }
}
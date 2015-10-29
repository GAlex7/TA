namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number on separated lines, for end enter blank line.");
            var input = string.Empty;
            var sequence = new List<int>();

            while ((input = Console.ReadLine()) != string.Empty)
            {
                sequence.Add(int.Parse(input));
            }

            Console.WriteLine("sum of the elements of the sequence is {0} and average is {1}.", sequence.Sum(), sequence.Average());
        }
    }
}

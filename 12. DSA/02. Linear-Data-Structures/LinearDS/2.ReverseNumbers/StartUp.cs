namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                   .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(n => int.Parse(n))
                   .ToList();

            var reversedNumbers = ReverseNumbers(numbers);

            foreach (var number in reversedNumbers)
            {
                Console.Write(number);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        private static ICollection<int> ReverseNumbers(ICollection<int> numbers)
        {
            var stackForReversing = new Stack<int>();

            numbers
                .ToList()
                .ForEach(n => stackForReversing.Push(n));

            var reversedNumbers = new List<int>();

            while (stackForReversing.Count > 0)
            {
                reversedNumbers.Add(stackForReversing.Pop());
            }

            return reversedNumbers;
        }
    }
}
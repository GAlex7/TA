// Problem 2. Enter numbers

// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace P02_EnterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EnterNumbers
    {
        static int start = 0;
        static int end = 100;
        static int count = 10;

        static int ReadNumber(int begin, int stop)
        {
            int numb = 99;
            bool IsNotInRange = true;
            do
            {
                Console.Write("Enter a number in range [{0}, {1}] : ", start, end);
                try
                {
                    numb = int.Parse(Console.ReadLine());
                    IsNotInRange = (numb < begin) || (numb > stop);
                    if (IsNotInRange)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            } while (IsNotInRange);
            return numb;

        }
        static void Main()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int x = ReadNumber(start, end);
                result.Add(x);
                start = x;
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

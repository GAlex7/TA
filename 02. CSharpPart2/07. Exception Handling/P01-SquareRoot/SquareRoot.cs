// Problem 1. Square root

// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

namespace P01_SquareRoot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            string numbAsString = Console.ReadLine();
            try
            {
                Console.WriteLine("Square roor from {0} is {1}.", uint.Parse(numbAsString),
                    Math.Sqrt(uint.Parse(numbAsString)));
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid number");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}

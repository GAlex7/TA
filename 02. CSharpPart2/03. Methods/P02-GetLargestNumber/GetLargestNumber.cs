// Problem 2. Get largest number

// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest
// of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_GetLargestNumber
{
    class GetLargestNumber
    {
        public static int GetMax(int x,int y)
        {
            return (x > y ? x : y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plesa enter 3 int numbers on one row separated by space:");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length < 3)
            {
                Console.WriteLine("I said 3 numbers... Bye!");
                return;
            }
            else if (input.Length > 3)
                Console.WriteLine("You entered more numbers, but I'll use only first 3.");
            int bigestNumb = GetMax(int.Parse(input[0]), int.Parse(input[1]));
            bigestNumb = GetMax(int.Parse(input[2]), bigestNumb);
            Console.WriteLine("The biggest number is {0}.",bigestNumb);
        }
    }
}

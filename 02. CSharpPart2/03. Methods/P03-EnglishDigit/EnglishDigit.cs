// Problem 3. English digit

// Write a method that returns the last digit of given integer as an English word.
// Examples:

// input	output
// 512	    two
// 1024	    four
// 12309	nine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_EnglishDigit
{
    class EnglishDigit
    {
        public static void LastDigitAsWord(int n)
        {
            string[] digitsAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            n = n % 10;
            Console.Write(digitsAsWords[n]);
        }
        static void Main(string[] args)
        {
            Console.Write("Plesa enter an int number: ");
            int numb = int.Parse(Console.ReadLine());
            Console.Write("Last digit of {0} is ", numb);
            LastDigitAsWord(numb);
            Console.WriteLine(".");
        }
    }
}

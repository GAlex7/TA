// Problem 7. One system to any other

// Write a program to convert from any numeral system of given base s 
// to any other numeral system of base d (2 ≤ s, d ≤ 16).


namespace P07_OneSystemToAnyOther
{
    using System;
    using System.Text;

    class OneSystemToAnyOther
    {
        public static string DecToBase(long numb, byte n)
        {
            StringBuilder result = new StringBuilder();
            long remainder;
            char currentChar;
            while (numb > 0)
            {
                remainder = numb % n;

                if (remainder < 10)
                    currentChar = (char)(remainder + '0');
                else
                    currentChar = (char)(remainder + 'a');

                result.Insert(0, currentChar);
                numb /= n;
            }
            return result.ToString().ToUpper();
        }

        public static long BaseToDec(string numb, byte n)
        {
            long number = 0;
            byte currentValue;
            numb = numb.ToLower();

            for (int i = 0; i < numb.Length; i++)
            {
                number *= n;
                if (Char.IsLetter(numb[i]))
                    currentValue = (byte)(numb[i] - 'a' + 10);
                else
                    currentValue = (byte)(numb[i] - '0');

                number += currentValue;
            }
            return number;
        }

        static void Main()
        {
            Console.Write("Enter number in any numeral system: ");
            string input = Console.ReadLine();
            Console.Write("What base is it? ");
            byte fromBase = byte.Parse(Console.ReadLine());
            Console.Write("In what base do you want to convert? ");
            byte toBase = byte.Parse(Console.ReadLine());
            Console.WriteLine(DecToBase(BaseToDec(input, fromBase), toBase));

        }
    }
}

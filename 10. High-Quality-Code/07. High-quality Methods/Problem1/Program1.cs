namespace Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program1
    {
        internal const string CODE = "0123456789abcdefghi";

        public static string DecToBase(long numb, byte n)
        {
            StringBuilder result = new StringBuilder();
            long remainder;
            char currentChar;
            while (numb > 0)
            {
                remainder = numb % n;

                if (remainder < 10)
                {
                    currentChar = (char)(remainder + '0');
                }
                else
                {
                    currentChar = (char)(remainder + 'a' - 10);
                }

                result.Insert(0, currentChar);
                numb /= n;
            }

            return result.ToString();
        }

        public static long BaseToDec(string numb, byte n)
        {
            long number = 0;
            byte currentValue;
            numb = numb.ToLower();

            for (int i = 0; i < numb.Length; i++)
            {
                number *= n;
                if (char.IsLetter(numb[i]))
                {
                    currentValue = (byte)(numb[i] - 'a' + 10);
                }
                else
                {
                    currentValue = (byte)(numb[i] - '0');
                }

                number += currentValue;
            }

            return number;
        }

        public static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            long[] numbInDec = new long[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = ConvertToNormalSystem(input[i]);
                numbInDec[i] = BaseToDec(input[i], 19);
            }

            long sumInDec = numbInDec.Sum();
            string sumIn19 = DecToBase(sumInDec, 19);

            Console.WriteLine("{0} = {1}", ConvertInCats(sumIn19), sumInDec);
        }

        private static string ConvertInCats(string p)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < p.Length; i++)
            {
                for (int j = 0; j < CODE.Length; j++)
                {
                    if (p[i] == CODE[j])
                    {
                        result.Append((char)('a' + j));
                        break;
                    }
                }
            }

            return result.ToString();
        }

        private static string ConvertToNormalSystem(string p)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < p.Length; i++)
            {
                result.Append(CODE[p[i] - 'a']);
            }

            return result.ToString();
        }
    }
}
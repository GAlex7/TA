// Problem 10. N Factorial

// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented 
// as array of digits by given integer number.


namespace P10_NFactorial
{
    using System;
    using System.Text;

    class NFactorial
    {
        static int[] Multiplie(int[] a, int[] b)
        {
            int len = a.Length + b.Length;
            int[,] abacus = new int[len, len];
            int mind = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    abacus[i, j + i] = (b[j] * a[i] + mind) % 10;
                    mind = (b[j] * a[i] + mind) / 10;
                }
                abacus[i, i + b.Length] = mind;
            }
            abacus[a.Length - 1, a.Length - 1 + b.Length] = mind;

            int[] result = new int[len];
            mind = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    result[i] += abacus[j, i];
                }
                result[i] += mind;
                mind = result[i] / 10;
                result[i] = result[i] % 10;
            }
            return result;
        }

        static int[] ConvNumbAsStrToDigitArr(string a, int len)
        {
            a = a.Insert(0, new string('0', len - a.Length));
            int[] numbA = new int[len];
            for (int i = 0; i < len; i++)
            {
                numbA[i] = int.Parse(a[len - i - 1].ToString());
            }
            return numbA;
        }

        static void Main()
        {
            Console.WriteLine("Please enter number (max 100).");
            Console.Write("N= ");
            string a = Console.ReadLine();

            int len = a.Length + 1;
            int[] DigArrA = ConvNumbAsStrToDigitArr(a, len);

            // int[] DigArrB = new int[len];

            for (int i = int.Parse(a)-1; i > 0; i--)
            {
                int[] DigArrB = ConvNumbAsStrToDigitArr(i.ToString(), len);
                DigArrA = Multiplie(DigArrA, DigArrB);
            }

            //Console.WriteLine(string.Join(" ", DigArrA));


            Array.Reverse(DigArrA);
            var factorial = new StringBuilder();
            for (int i = 0; i < DigArrA.Length; i++)
                factorial.Append(DigArrA[i]);
				 
			
            Console.WriteLine("N!= {0}",factorial.ToString().TrimStart('0'));
        }
    }
}

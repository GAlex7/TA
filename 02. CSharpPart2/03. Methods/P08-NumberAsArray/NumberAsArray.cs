// Problem 8. Number as array

// Write a method that adds two positive integer numbers represented as arrays of 
// digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.


namespace P08_NumberAsArray
{
    using System;
    using System.Text;
    //using System.
    class NumberAsArray
    {
        static int[] SumOfTwoBigNumbs(int[] x, int[] y)
        {
            int[] sumXY = new int[x.Length + 1];
            int prenos = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sumXY[i] = (x[i] + y[i] + prenos) % 10;
                prenos = (x[i] + y[i]) / 10;
            }
            sumXY[x.Length] = prenos;
            return sumXY;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers (each of them may have up to 10'000 digits).");
            Console.Write("Number 1= ");
            string a = Console.ReadLine();
            Console.Write("Number 2= ");
            string b = Console.ReadLine();
            bool isABigerThanB = a.Length > b.Length;
            int len = isABigerThanB ? a.Length : b.Length;
            if (isABigerThanB)
                b = b.Insert(0, new string('0', len - b.Length));
            else a = a.Insert(0, new string('0', len - a.Length));
            int[] numbA = new int[len];
            int[] numbB = new int[len];
            for (int i = 0; i < len; i++)
            {
                numbA[i] = int.Parse(a[len - i - 1].ToString());
                numbB[i] = int.Parse(b[len - i - 1].ToString());
            }
            int[] result = SumOfTwoBigNumbs(numbA, numbB);
            var finalResult = new StringBuilder(len + 1);
            for (int i = 0; i <= len; i++)
            {
                finalResult = finalResult.Insert(0, result[i].ToString());
            }
            Console.WriteLine("Sum= {0}", finalResult.ToString().TrimStart('0'));
        }
    }
}

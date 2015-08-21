// Problem 12. Subtracting polynomials

// Extend the previous program to support also subtraction and multiplication of polynomials.


namespace P12_SubtractingPolynomials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using P11_AddingPolynomials;

    class SubtractingPolynomials
    {
        static decimal[] Substract(List<decimal> a, List<decimal> b)
        {
            decimal[] result = new decimal[a.Count];
            for (int i = 0; i < a.Count; i++)
                result[i] = a[i] - b[i];
            return result;
        }

        static decimal[] Multiplicate(List<decimal> a, List<decimal> b)
        {
            decimal[] result = new decimal[(a.Count - 1) * 2 + 1];
            for (int nextDegree = 0; nextDegree <= (a.Count - 1) * 2; nextDegree++)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    for (int j = 0; j < a.Count; j++)
                    {
                        if ((i + j) == nextDegree)
                            result[nextDegree] += a[i] * b[j];
                    }
                }
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Please enter your first polynomial degree: ");
            int input = int.Parse(Console.ReadLine());
            List<decimal> polOne = new List<decimal>();
            for (int i = 0; i <= input; i++)
            {
                Console.Write("x^{0}= ", input - i);
                polOne.Add(decimal.Parse(Console.ReadLine()));
            }

            Console.Write("Please enter your second polynomial degree: ");
            input = int.Parse(Console.ReadLine());
            List<decimal> polTwo = new List<decimal>();
            for (int i = 0; i <= input; i++)
            {
                Console.Write("x^{0}= ", input - i);
                polTwo.Add(decimal.Parse(Console.ReadLine()));
            }
            if (polOne.Count > polTwo.Count)
            {
                for (int i = 0; i <= polOne.Count - polTwo.Count; i++)
                {
                    polTwo.Insert(0, 0);
                }
            }
            else
            {
                for (int i = 0; i <= polTwo.Count - polOne.Count; i++)
                {
                    polOne.Insert(0, 0);
                }
            }
            Console.WriteLine("\nA-B ->");
            AddingPolynomials.PrintPolinom(Substract(polOne,polTwo));
            Console.WriteLine("\nA*B ->");
            AddingPolynomials.PrintPolinom(Multiplicate(polOne, polTwo));
        }
    }
}

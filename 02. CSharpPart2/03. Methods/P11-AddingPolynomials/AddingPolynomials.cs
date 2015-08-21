// Problem 11. Adding polynomials

// Write a method that adds two polynomials.
// Represent them as arrays of their coefficients.
// Example:

// x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

namespace P11_AddingPolynomials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AddingPolynomials
    {
        static decimal[] AddPolinoms(decimal[] a, decimal[] b)
        {
            int diference = a.Length - b.Length;
            int len = a.Length > b.Length ? a.Length : b.Length;
            decimal[] arr = new decimal[len];
            for (int i = 0; i < len; i++)
            {
                if (diference > 0)
                    arr[i] = a[i] + (i - diference >= 0 ? b[i - diference] : 0);
                else arr[i] = b[i] + (i + diference >= 0 ? a[i + diference] : 0);
            }
            return arr;
        }

        public static void PrintPolinom(decimal[] poly)
        {
            for (int i = 0; i < poly.Length; i++)
            {
                if (poly[i] == 0)
                    continue;
                else if (i == poly.Length - 1)
                    Console.Write(" + {0}", poly[i]);
                else if (i == poly.Length - 2)
                    Console.Write(" + {0}.x", poly[i]);
                else if (i == 0)
                    Console.Write("{0}.x^{1}", poly[i], poly.Length - i - 1);
                else Console.Write(" + {0}.x^{1}", poly[i], poly.Length - i - 1);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Please enter your first polynomial degree: ");
            int input = int.Parse(Console.ReadLine());
            decimal[] polOne = new decimal[input+1];
            for (int i = 0; i <= input; i++)
            {
                Console.Write("x^{0}= ", input - i);
                polOne[i] = decimal.Parse(Console.ReadLine());
            }
            
            Console.Write("Please enter your second polynomial degree: ");
            input = int.Parse(Console.ReadLine());
            decimal[] polTwo = new decimal[input+1];
            for (int i = 0; i <= input; i++)
            {
                Console.Write("x^{0}= ", input - i);
                polTwo[i] = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("==================");
            PrintPolinom(polOne);
            PrintPolinom(polTwo);
            Console.WriteLine("Result is:");
            PrintPolinom(AddPolinoms(polOne, polTwo));
        }
    }
}

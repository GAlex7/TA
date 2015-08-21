// Problem 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic equation
// ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;
class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float a = float.Parse(Console.ReadLine().Replace('.', ','));
        float b = float.Parse(Console.ReadLine().Replace('.', ','));
        float c = float.Parse(Console.ReadLine().Replace('.', ','));

        double D = (b * b) - (4 * a * c);
        if (D > 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("X1= {0}; X2= {1}", x1, x2);
        }
        else if (D == 0)
        {
            double x1 = (-b) / (2 * a);
            Console.WriteLine("X1=X2= {0}", x1);
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}
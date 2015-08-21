// Problem 9. Trapezoids
// Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
using System.Globalization;
using System.Threading;
class Trapezoids
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Calculates trapezoid's area by given sides a and b and height h.");
        Console.Write("Side a : ");
        float a = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.Write("Side b : ");
        float b = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.Write("Height : ");
        float h = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.WriteLine("The trapezoid's area by given sides is {0:f2}.", (a + b) / 2 * h);
    }
}
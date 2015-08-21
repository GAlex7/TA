// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
// with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        float r = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.WriteLine("{0:f2}", 2 * (float)Math.PI * r);
        Console.WriteLine("{0:f2}", (float)Math.PI * r * r);
    }
}
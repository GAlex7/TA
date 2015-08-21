// Problem 7. Point in a Circle
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;
class PointInCircle
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Please enter a point coordinates (e.g. x ; y): ");
        string input = Console.ReadLine(); // "0.2 ;   -0,8";
        input = input.Replace('.', ',');
        string[] numStr = input.Split(';');
        float X = float.Parse(numStr[0]);
        float Y = float.Parse(numStr[1]);
        // In general, X and Y must satisfy (X - center_x)^2 + (Y - center_y)^2 < radius^2.
        bool isPointInCircle = X * X + Y * Y <= 4; // center_x & center_y = 0, radius = 2
        Console.WriteLine("This point is inside a circle K((0, 0), 2) --> {0}.", isPointInCircle);
    }
}
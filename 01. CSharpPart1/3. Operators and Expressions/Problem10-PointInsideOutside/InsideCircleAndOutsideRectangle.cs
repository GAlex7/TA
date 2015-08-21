// Problem 10. Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Globalization;
using System.Threading;
class InsideCircleAndOutsideRectangle
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
        bool isPointInCircle = (X - 1) * (X - 1) + (Y - 1) * (Y - 1) <= 1.5 * 1.5; // center_x & center_y = 1, radius = 1,5
        // Rectangle R(top=1, left=-1, width=6, height=2).
        bool isPointInRactangle = (X >= -1 && X <= 5) && (Y >= -1 && Y <= 1);

        Console.WriteLine("\nGiven point ({0:f2} , {1:f2}) is within the circle K((1, 1), 1.5) and \n" +
                          "out of the rectangle R(top=1, left=-1, width=6, height=2) --> {2}", X, Y, 
                          (isPointInCircle && !isPointInRactangle?"Yes":"No"));
    }
}
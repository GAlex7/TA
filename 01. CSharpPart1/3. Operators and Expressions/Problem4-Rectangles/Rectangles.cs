// Problem 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;
using System.Globalization;
using System.Text;
using System.Threading;
class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Calculates rectangle’s perimeter and area by given width and height.");
        Console.Write("Width  : ");
        float width = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.Write("Height : ");
        float height = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.WriteLine("The rectangle’s perimeter is {0:f2} and area is {1:f2}.", width * 2 + height * 2, width * height);
    }
}
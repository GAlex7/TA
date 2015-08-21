// Problem 2. Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;
class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Please enter the weight of a man: ");
        float manWeight = float.Parse(Console.ReadLine().Replace('.', ','));
        Console.WriteLine("The weight of a man on the moon will be {0:F2}.", manWeight * 0.17);
    }
}

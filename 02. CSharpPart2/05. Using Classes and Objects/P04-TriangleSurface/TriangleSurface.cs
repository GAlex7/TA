// Problem 4. Triangle surface

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

namespace P04_TriangleSurface
{
    using System;

    class TriangleSurface
    {
        static double TrianleSurf(double side, double altitude)
        {
            Console.WriteLine("side and altitude");
            return (side * altitude / 2);
        }
        static double TriangeSurf(double side1, double side2, double side3)
        {
            Console.WriteLine("3 sides");
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        static double TriangleSurf(double side1, double side2, double angle)
        {
            Console.WriteLine("2 sides and angle");
            return (side1 * side2 / 2 * Math.Sin(angle));
        }
        static void Main()
        {
            Console.WriteLine("This program calculates the surface of a triangle by given:");
            Console.WriteLine("1. Side and an altitude to it");
            Console.WriteLine("2. Three sides");
            Console.WriteLine("3. Two sides and an angle between them");
            Console.Write("What is your case: ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        Console.Write("Side a: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Altitude to it: ");
                        double altitude = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle is {0}", TrianleSurf(side, altitude));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Side a: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("Side b: ");
                        double side2 = double.Parse(Console.ReadLine());
                        Console.Write("Side c: ");
                        double side3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle is {0}", TriangeSurf(side1, side2, side3));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Side a: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("Side b: ");
                        double side2 = double.Parse(Console.ReadLine());
                        Console.Write("Angle between them: ");
                        double angle = double.Parse(Console.ReadLine());
                        Console.Write("Is the angle in degree (Y/N): ");
                        string answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y")
                            angle = ConvertDegreeToRadian(angle);
                        Console.WriteLine("Area of triangle is {0}", TriangleSurf(side1, side2, angle));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No such case!");
                        break;
                    }
            }
        }

        private static double ConvertDegreeToRadian(double angle)
        {
            return (angle * Math.PI / 180);
        }
    }
}

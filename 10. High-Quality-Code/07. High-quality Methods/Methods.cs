using System;

namespace Methods
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            bool isSidesPositive = a > 0 || b > 0 || c > 0;
            bool isSumOfTwoSidesLargerThanThirdSide = a + b > c && a + c > b && b + c > a;

            if (!isSidesPositive)
            {
                throw new ArgumentOutOfRangeException("All sides must be >= 0");
            }

            if (!isSumOfTwoSidesLargerThanThirdSide)
            {
                throw new ArgumentOutOfRangeException("Sum of the each two sides must be longer than other one");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            if (number < 0 || 9 < number)
            {
                throw new ArgumentException("Invalid digit.");
            }

            string[] digitsAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return digitsAsWord[number];
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberWithPrecision(1.3);
            PrintNumberAsPercentage(0.75);
            PrintNumberAlignedRight(2.30);

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.DateOfBirth = new DateTime(1992, 3, 17);
            peter.OtherInfo = "From Sofia";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.DateOfBirth = new DateTime(1993, 11, 3);
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPercentage(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}

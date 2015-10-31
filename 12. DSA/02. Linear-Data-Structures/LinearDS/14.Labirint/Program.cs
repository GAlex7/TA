namespace Labirint
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = @"6
0 0 0 x 0 x
0 x 0 x 0 x
0 * x 0 x 0
0 x 0 0 0 0
0 0 0 x x 0
0 0 0 x 0 x";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var desk = ReadDesk();
            var startPoint = GetStartPoint(desk);
            FillDistances(desk, startPoint);
            FillUnreachebleCells(desk);
            PrintDesk(desk);
        }

        private static string[,] ReadDesk()
        {
            var size = int.Parse(Console.ReadLine());
            var desk = new string[size, size];

            for (int r = 0; r < size; r++)
            {
                var rowSymbols = Console.ReadLine()
                            .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                for (int c = 0; c < size; c++)
                {
                    desk[r, c] = rowSymbols[c];
                }
            }

            return desk;
        }

        private static Point GetStartPoint(string[,] desk)
        {
            for (int r = 0; r < desk.GetLength(0); r++)
            {
                for (int c = 0; c < desk.GetLength(1); c++)
                {
                    if (desk[r, c] == "*")
                    {
                        return new Point(r, c);
                    }
                }
            }

            return null;
        }

        private static void FillDistances(string[,] desk, Point startPoint)
        {
            var size = desk.GetLength(0);
            var queue = new Queue<Point>();
            queue.Enqueue(startPoint);

            while (queue.Count > 0)
            {
                var currentPoint = queue.Dequeue();
                var r = currentPoint.Row;
                var c = currentPoint.Col;
                var surroundingPoints = new[]
                {
                    new Point(r, c - 1),  // left
                    new Point(r, c + 1),  // right
                    new Point(r - 1, c),  // up
                    new Point(r + 1, c)   // down
                };

                var currentSymbol = desk[r, c];
                var nextDistance = 1;

                if (currentSymbol != "*")
                {
                    nextDistance = int.Parse(currentSymbol) + 1;
                }

                foreach (var point in surroundingPoints)
                {
                    if (IsInDesk(point, size))
                    {
                        if (desk[point.Row, point.Col] == "0")
                        {
                            desk[point.Row, point.Col] = nextDistance.ToString();
                            queue.Enqueue(point);
                        }
                    }
                }
            }
        }

        private static void FillUnreachebleCells(string[,] desk)
        {
            for (int r = 0; r < desk.GetLength(0); r++)
            {
                for (int c = 0; c < desk.GetLength(1); c++)
                {
                    if (desk[r, c] == "0")
                    {
                        desk[r, c] = "u";
                    }
                }
            }
        }

        private static void PrintDesk(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,3}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsInDesk(Point point, int size)
        {
            var isRowCorrect = 0 <= point.Row && point.Row < size;
            var isColCorrect = 0 <= point.Col && point.Col < size;
            return isRowCorrect && isColCorrect;
        }
    }
}

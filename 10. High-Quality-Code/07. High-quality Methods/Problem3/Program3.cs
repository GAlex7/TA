namespace Problem3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program3
    {
        public static void Main()
        {
            int[] dim = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rows = dim[0];
            int cols = dim[1];
            int n = int.Parse(Console.ReadLine());
            int[,] board = new int[rows, cols];
            // fill board
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    board[r, c] = (r + c) * 3;
                }
            }

            int currRow = 0;
            int currCol = 0;
            int nextMoveR = 0;
            int nextMoveC = 0;

            int sum = board[0, 0];

            for (int i = 0; i < n; i++)
            {
                string[] move = Console.ReadLine().ToLower().Split(' ');
                if (move[0] == "ru")
                {
                    move[0] = "ur";
                }

                if (move[0] == "lu")
                {
                    move[0] = "ul";
                }

                if (move[0] == "rd")
                {
                    move[0] = "dr";
                }

                if (move[0] == "lu")
                {
                    move[0] = "ul";
                }

                nextMoveR = move[0][0] == 'u' ? 1 : -1;
                nextMoveC = move[0][1] == 'r' ? 1 : -1;

                for (int m = 0; m < int.Parse(move[1]) - 1; m++)
                {
                    if ((currRow + nextMoveR <= rows - 1 && currRow + nextMoveR >= 0) &&
                        (currCol + nextMoveC <= cols - 1 && currCol + nextMoveC >= 0))
                    {
                        currRow += nextMoveR;
                        currCol += nextMoveC;
                    }

                    sum += board[currRow, currCol];
                    board[currRow, currCol] = 0;
                }
            }

            Console.WriteLine(sum);

        }

        private static void PrintBoard(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,3} ", matrix[r, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
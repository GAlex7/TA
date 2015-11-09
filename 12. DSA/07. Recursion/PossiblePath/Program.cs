namespace PossiblePath
{
    using System;

    public class Program
    {
        private static bool pathFound = false;

        public static void Main()
        {
            var maze = new char[100, 100];
            CheckIfPathExists(0, 0, 72, 38, maze);
        }

        public static void CheckIfPathExists(int startRow, int startCol, int targetRow, int targetCol, char[,] maze)
        {
            if (pathFound)
            {
                return;
            }

            if (IsValidMove(startRow, startCol, maze))
            {
                maze[targetRow, targetCol] = 'E';

                if (maze[startRow, startCol] == 'E')
                {
                    Console.WriteLine("Path found!");
                    pathFound = true;
                    return;
                }

                maze[startRow, startCol] = '+';
                CheckIfPathExists(startRow - 1, startCol, targetRow, targetCol, maze);
                CheckIfPathExists(startRow, startCol + 1, targetRow, targetCol, maze);
                CheckIfPathExists(startRow + 1, startCol, targetRow, targetCol, maze);
                CheckIfPathExists(startRow, startCol - 1, targetRow, targetCol, maze);
            }
        }

        private static bool IsValidMove(int targetRow, int targetCol, char[,] maze)
        {
            if (targetRow >= maze.GetLength(0) || targetRow < 0 ||
                targetCol >= maze.GetLength(1) || targetCol < 0)
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == 'X')
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == '+')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

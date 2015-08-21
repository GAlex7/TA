namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mine
    {
        public static void Main(string[] аргументи)
        {
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] mines = InitMines();
            int boxCounter = 0;
            bool isMineDetonated = false;
            List<Score> rankList = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isGameStart = true;
            const int MaxBoxes = 35;
            bool isAllBoxesOpened = false;

            do
            {
                if (isGameStart)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck to find all mineless boxes." +
                    "\nCommands:\n'top' shows Highscores,\n'restart' start new game,\n'exit' Goodbye!");
                    Render(gameBoard);
                    isGameStart = false;
                }

                Console.Write("Which box? (R)ow and (C)olumn: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= gameBoard.GetLength(0) && col <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Highscores(rankList);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        mines = InitMines();
                        Render(gameBoard);
                        isMineDetonated = false;
                        isGameStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye! Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                Move(gameBoard, mines, row, col);
                                boxCounter++;
                            }

                            if (MaxBoxes == boxCounter)
                            {
                                isAllBoxesOpened = true;
                            }
                            else
                            {
                                Render(gameBoard);
                            }
                        }
                        else
                        {
                            isMineDetonated = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nOps! Invalid command\n");
                        break;
                }

                if (isMineDetonated)
                {
                    Render(mines);
                    Console.Write("\nHrrrrrr! You blow a mine... You succeeded to open {0} boxes.\nEnter your nickname: ",                        boxCounter);
                    string nickname = Console.ReadLine();
                    Score currentScore = new Score(nickname, boxCounter);
                    if (rankList.Count < 5)
                    {
                        rankList.Add(currentScore);
                    }
                    else
                    {
                        for (int i = 0; i < rankList.Count; i++)
                        {
                            if (rankList[i].Points < currentScore.Points)
                            {
                                rankList.Insert(i, currentScore);
                                rankList.RemoveAt(rankList.Count - 1);
                                break;
                            }
                        }
                    }

                    rankList.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    rankList.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    Highscores(rankList);

                    gameBoard = CreateGameBoard();
                    mines = InitMines();
                    boxCounter = 0;
                    isMineDetonated = false;
                    isGameStart = true;
                }

                if (isAllBoxesOpened)
                {
                    Console.WriteLine("\nCOOL! You succeeded to open 35 boxes without a drop of blood!");
                    Render(mines);
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Score currentScore = new Score(name, boxCounter);
                    rankList.Add(currentScore);
                    Highscores(rankList);
                    gameBoard = CreateGameBoard();
                    mines = InitMines();
                    boxCounter = 0;
                    isAllBoxesOpened = false;
                    isGameStart = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("So long!");
            Console.Read();
        }

        private static void Highscores(List<Score> scores)
        {
            Console.WriteLine("\nHighscores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, scores[i].Name, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty!\n");
            }
        }

        private static void Move(char[,] gameBoard, char[,] mines, int row, int col)
        {
            char minesAround = CalculateMinesAround(mines, row, col);
            mines[row, col] = minesAround;
            gameBoard[row, col] = minesAround;
        }

        private static void Render(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int r = 0; r < rows; r++)
            {
                Console.Write("{0} | ", r);
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(string.Format("{0} ", board[r, c]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int r = 0; r < boardRows; r++)
            {
                for (int c = 0; c < boardColumns; c++)
                {
                    board[r, c] = '?';
                }
            }

            return board;
        }

        private static char[,] InitMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameBoard = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> randomPositions = new List<int>();
            Random random = new Random();
            int nextRandomPosition = random.Next(50);

            while (randomPositions.Count < 15)
            {
                nextRandomPosition = random.Next(50);
                if (!randomPositions.Contains(nextRandomPosition))
                {
                    randomPositions.Add(nextRandomPosition);
                }
            }

            foreach (int currentPosition in randomPositions)
            {
                int col = currentPosition / cols;
                int row = currentPosition % cols;
                if (row == 0 && currentPosition != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameBoard[col, row - 1] = '*';
            }

            return gameBoard;
        }

        private static void RefreshGameBoard(char[,] gameBoard)
        {
            int col = gameBoard.GetLength(0);
            int row = gameBoard.GetLength(1);

            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    if (gameBoard[c, r] != '*')
                    {
                        char minesAround = CalculateMinesAround(gameBoard, c, r);
                        gameBoard[c, r] = minesAround;
                    }
                }
            }
        }

        private static char CalculateMinesAround(char[,] gameBoard, int col, int row)
        {
            int counter = 0;
            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);

            if (col - 1 >= 0)
            {
                if (gameBoard[col - 1, row] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < rows)
            {
                if (gameBoard[col + 1, row] == '*')
                {
                    counter++;
                }
            }

            if (row - 1 >= 0)
            {
                if (gameBoard[col, row - 1] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < cols)
            {
                if (gameBoard[col, row + 1] == '*')
                {
                    counter++;
                }
            }

            if ((col - 1 >= 0) && (row - 1 >= 0))
            {
                if (gameBoard[col - 1, row - 1] == '*')
                {
                    counter++;
                }
            }

            if ((col - 1 >= 0) && (row + 1 < cols))
            {
                if (gameBoard[col - 1, row + 1] == '*')
                {
                    counter++;
                }
            }

            if ((col + 1 < rows) && (row - 1 >= 0))
            {
                if (gameBoard[col + 1, row - 1] == '*')
                {
                    counter++;
                }
            }

            if ((col + 1 < rows) && (row + 1 < cols))
            {
                if (gameBoard[col + 1, row + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }

        public class Score
        {
            private string name;
            private int points;

            public Score()
            {
            }

            public Score(string name, int score)
            {
                this.Name = name;
                this.Points = score;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }
    }
}
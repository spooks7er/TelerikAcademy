namespace Mines
{
    using System;
    using System.Collections.Generic;

    public static class Game
    {
        internal static void HighScores(List<PointsGetter> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        internal static void YourTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = Count(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        internal static void DwarMinesField(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < boardCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        internal static char[,] CreateField()
        {
            int boardRows = 5;
            int boardCols = 10;
            char[,] board = new char[boardRows, boardCols];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardCols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        internal static char[,] PutBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> rngSpread = new List<int>();

            while (rngSpread.Count < 15)
            {
                Random random = new Random();
                int rand = random.Next(50);
                if (!rngSpread.Contains(rand))
                {
                    rngSpread.Add(rand);
                }
            }

            foreach (int rng in rngSpread)
            {
                int kol = rng / cols;
                int red = rng % cols;

                if (red == 0 && rng != 0)
                {
                    kol--;
                    red = cols;
                }
                else
                {
                    red++;
                }

                field[kol, red - 1] = '*';
            }

            return field;
        }

        private static char Count(char[,] bombs, int row, int col)
        {
            int counter = 0;
            int bombsRows = bombs.GetLength(0);
            int bombsCols = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < bombsRows)
            {
                if (bombs[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (bombs[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < bombsCols)
            {
                if (bombs[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (bombs[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < bombsCols))
            {
                if (bombs[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < bombsRows) && (col - 1 >= 0))
            {
                if (bombs[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < bombsRows) && (col + 1 < bombsCols))
            {
                if (bombs[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}

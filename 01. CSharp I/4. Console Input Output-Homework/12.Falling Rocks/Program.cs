using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    const char _BORDER_CHAR = '\u25A0';

    const int _FIELD_WIDTH = 31;
    const int _FIELD_HEIGHT = 15;

    const int _INFO_WIDTH = 10;
    const int _INFO_HEIGHT = _FIELD_HEIGHT;

    const int _GAME_WIDTH = _FIELD_WIDTH + _INFO_WIDTH + 3;
    const int _GAME_HEIGHT = _FIELD_HEIGHT + 2;

    static Random random = new Random();

    static string Dwarf = "(O)";
    static char[] Rocks = { '!', '@', '#', '$', '%', '^', '&', '*', ':', ';', '+', 'V', '|', '~' };
    static int currentDwarfCol = 16;
    static char[,] gameState = new char[_FIELD_HEIGHT, _FIELD_WIDTH];

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.CursorVisible = false;
        Console.Title = "Faling Rocks";
        Console.WindowWidth = _GAME_WIDTH;
        Console.BufferWidth = _GAME_WIDTH;
        Console.WindowHeight = _GAME_HEIGHT + 1;
        Console.BufferHeight = _GAME_HEIGHT + 1;

        PrintBorders();
        PrintDwarf();
        Thread dwarfControls = new Thread(new ThreadStart(DwarfControls));
        dwarfControls.Start();

        DrawingRocks();
    }
    // todo // neshto zapecnah na padaneto na kamanite i ne ostana vreme :(
    static void FallingRocks()
    {
        for (int row = 1; row < _GAME_HEIGHT; row++)
        {
            for (int col = 1; col < _GAME_WIDTH; col++)
            {
                gameState[row + 1, col] = gameState[row, col];
                Print(row + 1, col, gameState[row, col]);
                if (gameState[row, col] != ' ')
                {
                    gameState[row, col] = ' ';
                }
            }
        }
    }

    static void DrawingRocks()
    {
        int row = 1;
        int col = random.Next(1, 32);
        while (true)
        {
            char randomRock = Rocks[random.Next(0, Rocks.Length)];
            Print(row, col, randomRock);
            gameState[row, col - 1] = randomRock;
            //row++;
            col = random.Next(1, 32);

            Print(_GAME_HEIGHT - _GAME_HEIGHT + 1, _FIELD_WIDTH + 1, _BORDER_CHAR);

            Thread.Sleep(150);
            //if (row>_FIELD_HEIGHT)
            //{
            //    row = 1;
            //}

        }
    }

    static void DwarfControls()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Print(_GAME_HEIGHT - 2, currentDwarfCol + 2, ' ');

                    if (currentDwarfCol > 1)
                    {
                        currentDwarfCol--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Print(_GAME_HEIGHT - 2, currentDwarfCol, ' ');

                    if (currentDwarfCol + Dwarf.Length - 1 < _FIELD_WIDTH)
                    {
                        currentDwarfCol++;
                    }
                }
                Print(_GAME_HEIGHT - 2, _FIELD_WIDTH + 1, _BORDER_CHAR);

            }
            PrintDwarf();
            //PrintGameField();
            Thread.Sleep(30);

        }
    }

    static void PrintDwarf()
    {
        for (int i = 0; i < Dwarf.Length; i++)
        {
            Print(_GAME_HEIGHT - 2, currentDwarfCol + i, Dwarf[i]);
        }
    }

    static void PrintBorders()
    {
        for (int col = 0; col < _GAME_WIDTH; col++)
        {
            Print(0, col, _BORDER_CHAR);
            Print(_GAME_HEIGHT - 1, col, _BORDER_CHAR);
        }

        for (int row = 0; row < _GAME_HEIGHT; row++)
        {
            Print(row, 0, _BORDER_CHAR);
            Print(row, _FIELD_WIDTH + 1, _BORDER_CHAR);
            Print(row, _FIELD_WIDTH + 1 + _INFO_WIDTH + 1, _BORDER_CHAR);
        }
    }

    static void Print(int row, int col, object data)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(col, row);
        Console.Write(data);
    }

}
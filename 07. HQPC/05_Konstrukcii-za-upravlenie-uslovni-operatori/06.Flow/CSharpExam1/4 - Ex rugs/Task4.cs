using System;

public class Task4
{
    private static char[,] carpet;
    private static int cursorCol = 0;
    private static int cursorRow = 0;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //N
        int centerWidth = int.Parse(Console.ReadLine()); //D

        //int n = 13;
        //int centerWidth = 3;

        int height = (2 * n) + 1;
        int width = height;

        int canvasWidth = centerWidth + width + 1;

        carpet = new char[height, canvasWidth];

        // draw blank canvas
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < canvasWidth; j++)
            {
                carpet[i, j] = '.';
            }
        }

        // draw left border
        for (int i = 0; i < height / 2; i++)
        {
            Draw('\\', 1, 1);
        }

        Draw('X', 1, -1);

        for (int i = (height / 2) + 1; i < height; i++)
        {
            Draw('/', 1, -1);
        }

        // draw right brder
        cursorRow = 0;
        cursorCol = canvasWidth - 1;
        for (int i = 0; i < height / 2; i++)
        {
            Draw('/', 1, -1);
        }

        Draw('X', 1, 1);

        for (int i = (height / 2) + 1; i < height; i++)
        {
            Draw('\\', 1, 1);
        }

        // draw inner border top
        int innerLength = (height - centerWidth - 2) / 2;
        cursorRow = 0;
        cursorCol = centerWidth + 1;
        for (int i = 0; i < innerLength; i++)
        {
            Draw('\\', 1, 1);
        }

        Draw('X', -1, 1);

        for (int i = 0; i < innerLength; i++)
        {
            Draw('/', -1, 1);
        }

        // draw inner border bot
        cursorRow = height - 1;
        cursorCol = centerWidth + 1;
        for (int i = 0; i < innerLength; i++)
        {
            Draw('/', -1, 1);
        }

        Draw('X', 1, 1);

        for (int i = 0; i < innerLength; i++)
        {
            Draw('\\', 1, 1);
        }

        // Fill carpet with #
        // fill diagonal left to bottom
        for (int i = 0; i < centerWidth; i++)
        {
            cursorRow = 0;
            cursorCol = i + 1;
            for (int j = 0; j < height; j++)
            {
                Draw('#', 1, 1);
            }
        }

        // fill daigonal right to bottom
        for (int i = 0; i < centerWidth; i++)
        {
            cursorRow = 0;
            cursorCol = (canvasWidth - 2) - i;
            for (int j = 0; j < height; j++)
            {
                Draw('#', 1, -1);
            }
        }

        // crop and print canvas with rug
        int start = (canvasWidth - width) / 2;
        PrintCroppedCanvas(start);
    }
    
    private static void PrintCroppedCanvas(int start)
    {
        for (int i = 0; i < carpet.GetLength(0); i++)
        {
            for (int j = start; j < carpet.GetLength(1) - start; j++)
            {
                Console.Write(carpet[i, j]);
            }

            Console.WriteLine();
        }
    }

    private static void Draw(char character, int rowDir, int colDir)
    {
        carpet[cursorRow, cursorCol] = character;
        cursorRow += rowDir;
        cursorCol += colDir;
    }
}
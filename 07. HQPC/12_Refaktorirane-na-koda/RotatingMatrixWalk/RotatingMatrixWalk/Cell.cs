namespace RotatingMatrixWalk
{
    using System;

    public class Cell
    {
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public static Cell operator +(Cell callA, Cell cellB)
        {
            if (callA == null || cellB == null)
            {
                throw new ArgumentNullException("Neither cell operands cannot be null.");
            }

            return new Cell(callA.X + cellB.X, callA.Y + cellB.Y);
        }
    }
}

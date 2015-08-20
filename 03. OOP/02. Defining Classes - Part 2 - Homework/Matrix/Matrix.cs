using System;
using System.Text;

namespace Matrix
{
    public class Matrix<T>
    {
        private T[,] matrix;

        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;

            matrix = new T[this.rows, this.cols];
        }

        public Matrix(T[,] array)
        {
            this.matrix = array;
            this.rows = array.GetLength(0);
            this.cols = array.GetLength(1);
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }


        // indexer
        public T this[int i, int j]
        {
            get
            {
                if (i >= rows || j >= cols)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0},{1}.", i, j));
                }
                T result = matrix[i, j];
                return result;
            }

            set
            {
                if (i >= rows || j >= cols)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0},{1}.", i, j));
                }
                matrix[i, j] = value;
            }
        }

        // Operators
        // +
        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows && a.Cols != b.Cols)
            {
                throw new ArgumentException
                    ("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> matrixAB = new Matrix<T>(a.Rows, b.Cols);

            for (int r = 0; r < matrixAB.Rows; r++)
            {
                for (int c = 0; c < matrixAB.Cols; c++)
                {
                    matrixAB[r, c] = (dynamic)a[r, c] + b[r, c];
                }
            }
            return matrixAB;
        }

        // -
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows && a.Cols != b.Cols)
            {
                throw new ArgumentException
                    ("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> matrixAB = new Matrix<T>(a.Rows, b.Cols);

            for (int r = 0; r < matrixAB.Rows; r++)
            {
                for (int c = 0; c < matrixAB.Cols; c++)
                {
                    matrixAB[r, c] = (dynamic)a[r, c] - b[r, c];
                }
            }
            return matrixAB;
        }

        // *
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ArgumentException("Matrices cannot be multiplied");
            }

            Matrix<T> matrixAB = new Matrix<T>(a.Rows, b.Cols);

            for (int r = 0; r < matrixAB.Rows; r++)
            {
                for (int c = 0; c < matrixAB.Cols; c++)
                {
                    T value = (dynamic)0;
                    for (int i = 0; i < a.Cols; i++)
                    {
                        value += (dynamic)a[r, i] * b[i, c];
                    }
                    matrixAB[r, c] = value;
                }
            }
            return matrixAB;
        }
        //

        // ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Append(string.Format("{0,5}", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        // Bool operators for zero elements
        public static bool operator true(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }
            return nonZeroElements;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }
            return nonZeroElements;
        }
        //

    }
}

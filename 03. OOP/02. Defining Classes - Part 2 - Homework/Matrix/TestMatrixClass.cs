using System;
//11 14 17 20
//23 30 37 44
//35 46 57 68
namespace Matrix
{
    class TestMatrixClass
    {
        public static void Main(string[] args)
        {
            //			Matrix<int> neo = new Matrix<int>(5,5);
            //			{
            //				{5, 6, 5, 7, 7},
            //				{5, 6, 5, 7, 7},
            //				{5, 6, 5, 7, 7},
            //				{5, 6, 5, 7, 7},
            //				{5, 6, 5, 7, 7}
            //			};

            //int[,] array = {
            //    {5, 6, 5, 7, 7},
            //    {5, 6, 5, 7, 7},
            //    {5, 6, 5, 7, 7},
            //    {5, 6, 5, 7, 7},
            //    {5, 6, 5, 7, 7}};

            int[,] a = {{1,2},
			            {3,4},
			            {5,6}};

            int[,] b = {{1,2,3,4},
			            {5,6,7,8}};

            Matrix<int> neo = new Matrix<int>(a);

            Matrix<int> smith = new Matrix<int>(b);

            Matrix<int> addmat = neo * smith; // change operator to + , - or *
            //smith[3,3] = 122;

            Console.WriteLine(addmat.ToString());
        }
    }
}
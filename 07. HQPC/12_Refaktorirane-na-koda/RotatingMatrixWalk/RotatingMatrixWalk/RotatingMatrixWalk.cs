namespace RotatingMatrixWalk
{
    using System;

    public class RotatingMatrixWalk
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a positive number ");

            string input = args[0];//Console.ReadLine();

            int n;

            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            //int n = 3;

            Matrix matrix = new Matrix(n);
            Console.WriteLine(matrix);
        }
    }
}
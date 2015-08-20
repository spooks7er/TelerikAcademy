namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b < c || a + c < b || b + c < a)
            {
                throw new Exception("Invalid triangle dimensions");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new Exception(digit + " is not a digit.");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new Exception("No parameters were passesd to method");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        public static void PrintAsFormatedNumber(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool IsHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        public static bool IsVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsFormatedNumber(1.3, "f");
            PrintAsFormatedNumber(0.75, "%");
            PrintAsFormatedNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + IsVertical(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov");
            peter.DateOfBirth = DateTime.Parse("17.03.1992");
            peter.PlaceOfBirth = City.Sofia;

            Student stella = new Student("Stella", "Markova");
            stella.DateOfBirth = DateTime.Parse("03.11.1993");
            stella.PlaceOfBirth = City.Vidin;

            Console.WriteLine("Is {0} older than {1}? -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

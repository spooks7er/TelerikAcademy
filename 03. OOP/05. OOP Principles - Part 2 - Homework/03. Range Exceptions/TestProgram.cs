using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            const int lower = 0;
            const int upper = 100;
            DateTime LowerDate = new DateTime(1980, 1, 1);
            DateTime UpperDate = new DateTime(2013, 12, 31);
            try
            {
                int wrongNumber = 150;
                if (wrongNumber < lower || wrongNumber > upper)
                {
                    throw new InvalidRangeException<int>("Number out of range!", lower, upper);
                }

                DateTime wrongDate = new DateTime(2015, 10, 15);
                if (wrongDate < LowerDate || wrongDate > UpperDate)
                {
                    throw new InvalidRangeException<DateTime>("Date out of range!", LowerDate, UpperDate);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Wrong number entered. Number must be in range {0} - {1}", ex.Min, ex.Max);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Wrong date entered. Date must be in range {0:dd/MM/yyyy} - {1:dd/MM/yyyy}", ex.Min, ex.Max);
            }
        }
    }
}

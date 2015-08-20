using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your birth date below.");
            DateTime bd = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - bd.Year;
            if ((today.Month < bd.Month || (today.Month == bd.Month && today.Day < bd.Day)))
            {
                age--;
            }
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("After 10 years you will be " + (age + 10) + " old.");
        }
    }
}



namespace BadCode2
{
    using System;

    class StartHere
    {
        static void Main(string[] args)
        {
            Human myHuman = MakeHuman(19);
            Console.WriteLine(myHuman.ToString());
        }

        public static Human MakeHuman(int age)
        {
            Human newHuman = new Human();
            newHuman.Age = age;

            if (age % 2 == 0)
            {
                newHuman.Name = "Батката";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Gender = Gender.Female;
            }

            return newHuman;
        }
    }
}
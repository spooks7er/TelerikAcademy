using System;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        private static readonly string sex = "Female";

        public Kitten(int age, string name, string breed)
            : base(age, name, sex, breed)
        {

        }
    }
}

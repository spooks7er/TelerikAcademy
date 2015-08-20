using System;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        private static readonly string sex = "Male";

        public Tomcat(int age, string name, string breed)
            : base(age, name, sex, breed)
        {

        }
    }
}

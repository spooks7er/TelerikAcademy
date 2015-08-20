using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void Sound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}

using System;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        private string breed;
        private readonly string sound = "Meow, meow!";

        public Cat(int age, string name, string sex, string breed)
            : base(age, name, sex)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public void Sound()
        {
            this.Sound(sound);
        }
    }
}

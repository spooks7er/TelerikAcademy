using System;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        private string breed;
        private readonly string sound = "Ribbit!";

        public Frog(int age, string name, string sex, string breed)
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

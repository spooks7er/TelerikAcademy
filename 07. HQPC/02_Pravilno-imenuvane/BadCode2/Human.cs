namespace BadCode2
{
    using System;

    class Human
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Gender: {0}, Name: {1}, Age: {2}", Gender, Name, Age);
        }
    }
}



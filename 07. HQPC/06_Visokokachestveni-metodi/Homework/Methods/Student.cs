namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new Exception("First name must be between 2 and 30 characters long.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new Exception("Last name must be between 2 and 30 characters long.");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public City PlaceOfBirth { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = other.DateOfBirth;

            return firstDate > secondDate;
        }
    }
}

namespace _03___05.Students
{
    using System;

    internal class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string Firstname
        {
            get
            {
                return this.firstName;
            }

            set
            {
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
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be non negative number.");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}, LastName: {1}, Age: {2}", this.Firstname, this.LastName, this.Age);
        }
    }
}

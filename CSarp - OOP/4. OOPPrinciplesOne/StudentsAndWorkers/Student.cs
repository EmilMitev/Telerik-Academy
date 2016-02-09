namespace StudentsAndWorkers
{
    using System;

    internal class Student : Human
    {
        public Student(string firstname, string lastname, float grade)
           : base(firstname, lastname)
        {
            this.Grade = grade;
        }

        public float Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} : {2}", this.Firstname, this.Lastname, this.Grade);
        }
    }
}

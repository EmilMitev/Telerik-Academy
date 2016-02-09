namespace _09.StudentGroup
{
    using System.Collections.Generic;

    internal class Student
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, string fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<int>(marks);
            this.GroupNumber = groupNumber;
        }

        public string FirstName
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

        public string FN
        {
            get
            {
                return this.fN;
            }

            set
            {
                this.fN = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nFN: {2}\nTel: {3}\nEmail: {4}\nMarks: {5}\nGroupNumber: {6}\n", this.FirstName, this.LastName, this.FN, this.Tel, this.Email, string.Join(" ", this.Marks), this.GroupNumber);
        }
    }
}
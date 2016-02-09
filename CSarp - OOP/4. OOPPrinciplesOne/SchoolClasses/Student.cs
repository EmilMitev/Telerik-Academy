﻿namespace SchoolClasses
{
    using System.Collections.Generic;

    internal class Student : People
    {
        private static List<int> takenNumbers;

        private int classNumber;

        private string comment;

        public Student(string n, int num, string comment = null) : base(n)
        {
            this.ClassNumber = num;

            this.comment = comment;
        }

        public string Comment { get; set; }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (!CheckIfTaken(value))
                {
                    this.ClassNumber = value;
                }
                else
                {
                    throw new TakenNumberException("Class number already taken.");
                }
            }
        }

        private static bool CheckIfTaken(int num)
        {
            if (takenNumbers.Contains(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

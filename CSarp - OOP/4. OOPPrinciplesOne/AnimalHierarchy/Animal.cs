namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    internal abstract class Animal : ISound
    {
        private string name;

        private sbyte age;

        private Sex sex;

        internal Animal(string name, sbyte age, Sex s)
        {
            this.Name = name;

            this.Age = age;

            this.Sex = s;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public sbyte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
            }
        }

        public static int CalculateAverageYears<T>(List<T> animals) where T : Animal
        {
            int totalYears = 0;
            int count = 0;

            foreach (var animal in animals)
            {
                totalYears += animal.Age;
                count++;
            }

            return totalYears / count;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound.");
        }
    }
}

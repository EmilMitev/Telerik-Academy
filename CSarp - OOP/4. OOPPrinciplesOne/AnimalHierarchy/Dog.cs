namespace AnimalHierarchy
{
    using System;

    internal class Dog : Animal
    {
        public Dog(string name, sbyte age, Sex s)
            : base(name, age, s)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau Bau!");
        }
    }
}
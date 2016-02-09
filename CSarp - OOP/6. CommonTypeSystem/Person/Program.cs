namespace Person
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person vanya = new Person("Vanya", 18);
            Person voldemort = new Person("Voldemort");

            Console.WriteLine(vanya);
            Console.WriteLine(voldemort);
        }
    }
}
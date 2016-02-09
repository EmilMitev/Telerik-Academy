namespace Structure
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Path path = PathStorage.LoadPath();

            PathStorage.SavePath(path);
            Console.WriteLine("done");
        }
    }
}
